namespace BaharNarenjERP
{
    class AppProperties
    {
        public struct User
        {
            public static string userID;
            public static string persID;
            public static string persFName;
            public static string persLName;
            public static string brID;
            public static string brName;
        }

        public struct ConStr
        {
            public static string Server = Properties.Settings.Default.Server;
            public static uint Port = Properties.Settings.Default.Port;
            public static string UserID = Properties.Settings.Default.UserID;
            public static string Password = Properties.Settings.Default.Password;
            public static string DataBase = Properties.Settings.Default.DataBase;
        }

        public static object SenderObject;
        public static string SenderString;
        public static object SenderObject2;
        public static string PrCode;
        public static string WrCode;
        public const string MasterPassword = "BaharNarenj32303230";
        public static bool MasterEntrance = false;
        public static bool ForceClose = false;
        public static bool ModalAccess = false;
    }
}
