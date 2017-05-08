using System;
using System.Net;
using System.Net.Sockets;

namespace BaharNarenjERP
{
    class NtpTime
    {
        //default Windows time server
        private readonly string _ntpServer;
        private readonly int _timeZone;
        
        private TimeSpan TimeZone => new TimeSpan(_timeZone/60, _timeZone%60, 0);

        public NtpTime()
        {
            _ntpServer = "time.windows.com";
            _timeZone = 0;
        }
        public NtpTime(string server)
        {
            _ntpServer = server;
            _timeZone = 0;
        }
        public NtpTime(string server,int timezone)
        {
            _ntpServer = server;
            _timeZone = timezone;
        }
        public DateTime Now
        {
            get
            {
                // NTP message size - 16 bytes of the digest (RFC 2030)
                var ntpData = new byte[48];

                //Setting the Leap Indicator, Version Number and Mode values
                ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

                var addresses = Dns.GetHostEntry(_ntpServer).AddressList;

                //The UDP port number assigned to NTP is 123
                var ipEndPoint = new IPEndPoint(addresses[0], 123);
                //NTP uses UDP
                var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                socket.Connect(ipEndPoint);

                //Stops code hang if NTP is blocked
                socket.ReceiveTimeout = 3000;

                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();

                //Offset to get to the "Transmit Timestamp" field (time at which the reply 
                //departed the server for the client, in 64-bit timestamp format."
                const byte serverReplyTime = 40;

                //Get the seconds part
                ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

                //Get the seconds fraction
                ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

                //Convert From big-endian to little-endian
                intPart = SwapEndianness(intPart);
                fractPart = SwapEndianness(fractPart);

                var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

                //**UTC** time
                var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);
                var ts=new TimeSpan(3,30,0);

                return networkDateTime + TimeZone;
            }
        }
        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }

        
    }
}
