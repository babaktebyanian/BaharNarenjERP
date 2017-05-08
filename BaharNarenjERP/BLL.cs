using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Stimulsoft.Report;
using System.Net.Mail;
using System.Text.RegularExpressions;
using Persia;

namespace BaharNarenjERP
{
    class BLL
    {

        #region Global Methods

        private SolarDate _now;
        public static class Globals
        {
            public static void SetUser(string userId)
            {
                try
                {
                    AppProperties.User.userID = userId;
                    AppProperties.User.brID = DAC.ComboBoxReturn("brID", "Users", "userID", userId).ToString();
                    AppProperties.User.persID = DAC.ComboBoxReturn("persID", "Users", "userID", userId).ToString();
                    AppProperties.User.brName = DAC.ComboBoxReturn("BranchName", "Branches", "brID", AppProperties.User.brID).ToString();
                    AppProperties.User.persFName = DAC.ComboBoxReturn("persFName", "Personnel", "persID", AppProperties.User.persID).ToString();
                    AppProperties.User.persLName = DAC.ComboBoxReturn("persLName", "Personnel", "persID", AppProperties.User.persID).ToString();
                }
                catch
                {
                    // ignored
                }
                var query =
                    $"INSERT INTO Logons (userID, lgDate) VALUES ('{userId}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}');";
                try
                {
                    DAC.ExecuteSql(query);
                }
                catch
                {
                    //ignored
                }
            }
        }
        public static string ToIntDate(string maskedDate)
        {
            var d = maskedDate;
            try
            {
                d = d.Remove(4, 1);
                d = d.Remove(6, 1);

                if (d.Trim() == "")
                    d = "13930101";
            }
            catch
            {
                d = "13930101";
            }
            return d;
        }

        public static string ToDateValue(string intDate)
        {
            var d = intDate;
            try
            {
                d = d.Insert(4, "/");
                d = d.Insert(7, "/");
                if (d.Trim() == "//")
                    d = "1393/01/01";
            }
            catch (Exception)
            {
                d = "1393/01/01";
            }
            return d;
        }

        public static string Today
        {
            get
            {
                var pc = new PersianCalendar();
                //var gregDate = DateTime.Now;
                DateTime gregDate;
                try
                {
                    var t = new NtpTime(Properties.Settings.Default.TimeServer,
                        Properties.Settings.Default.TimeZoneHour * 60 + Properties.Settings.Default.TimeZoneMinute);
                    //return Persia.Calendar.ConvertToPersian(t.Now).ToString();
                    gregDate = t.Now;
                }
                catch
                {
                    gregDate = DateTime.Now;
                    //return Persia.Calendar.ConvertToPersian(DateTime.Now).ToString();
                }
                var month = pc.GetMonth(gregDate).ToString(CultureInfo.InvariantCulture);
                month = int.Parse(month) < 10 ? ("0" + month) : month;
                var day = pc.GetDayOfMonth(gregDate).ToString(CultureInfo.InvariantCulture);
                day = int.Parse(day) < 10 ? ("0" + day) : day;
                return pc.GetYear(gregDate) + "/" + month + "/" + day;
            }
        }

        public static string PersianDate(DateTime d)
        {
            var pc = new PersianCalendar();
            var month = pc.GetMonth(d).ToString(CultureInfo.InvariantCulture);
            month = int.Parse(month) < 10 ? ("0" + month) : month;
            var day = pc.GetDayOfMonth(d).ToString(CultureInfo.InvariantCulture);
            day = int.Parse(day) < 10 ? ("0" + day) : day;
            return pc.GetYear(d) + "/" + month + "/" + day;
        }

        public static bool LogWriter(string log)
        {
            var q =
                $@"INSERT INTO Logs (LogDate, userID, Log) VALUES ('{BLL.Today} {DateTime.Now.Hour}:{DateTime.Now.Minute
                    }:{DateTime.Now.Second}', '{AppProperties.User.userID}', '{log}');";
            return DAC.ExecuteSql(q);
        }
        public static bool MailIsValid(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool MailIsValidStrict(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
        public static class RegexUtilities
        {
            static bool _invalid;

            public static bool IsValidEmail(string email)
            {
                _invalid = false;
                if (string.IsNullOrEmpty(email))
                    return false;   

                // Use IdnMapping class to convert Unicode domain names.
                try
                {
                    email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                          RegexOptions.None, TimeSpan.FromMilliseconds(200));
                }
                catch (RegexMatchTimeoutException)
                {
                    return false;
                }

                if (_invalid)
                    return false;

                // Return true if strIn is in valid e-mail format.
                try
                {
                    return Regex.IsMatch(email,
                          @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                          @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                          RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                }
                catch (RegexMatchTimeoutException)
                {
                    return false;
                }
            }

            private static string DomainMapper(Match match)
            {
                // IdnMapping class with default property values.
                var idn = new IdnMapping();

                var domainName = match.Groups[2].Value;
                try
                {
                    domainName = idn.GetAscii(domainName);
                }
                catch (ArgumentException)
                {
                    _invalid = true;
                }
                return match.Groups[1].Value + domainName;
            }
        }

        public static bool IsValidIpV4(string ip)
        {
            var octets = ip.Split('.');
            if (octets.Length != 4)
                return false;
            foreach (var octet in octets)
            {
                int o;
                // if parse fails 
                // or length of parsed int != length of octet string (i.e.; '1' vs '001')
                // or parsed int < 0
                // or parsed int > 255
                // return false
                if (!int.TryParse(octet, out o) || !o.ToString().Length.Equals(octet.Length) || o < 0 || o > 255)
                {
                    return false;
                }
            }
            return true;
        }

        public static void AllowNumbersOnly(KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        #endregion

        #region LogIn Class

        public static class LogIn
        {
            public static bool ComboFill(ComboBox user)
            {
                return DAC.ComboBoxFill("Users", "userID", user);
            }
        }

        #endregion

        #region Data Interface Class

        public static class DataIfC
        {
            /// <summary>
            /// Binds a database table to a DataGridView.
            /// </summary>
            /// <param name="dgv">The DataGridView to be bound.</param>
            /// <param name="dt">The DataTable to be filled by a query from SQL database.</param>
            /// <param name="da">The DataAdapter to do the query.</param>
            /// <param name="bs">The BindingSource as the DataGridView's data source.</param>
            /// <param name="selectQuery">The query to be done against SQL Database.</param>
            public static void DataBind(DataGridView dgv, DataTable dt, MySqlDataAdapter da, BindingSource bs, string selectQuery)
            {
                dgv.DataSource = null;
                dt.Clear();
                DAC.DataBind(dt, da, bs, selectQuery);
                dgv.DataSource = bs;
            }

        }

        #endregion

        #region Reports

        public static class Reports
        {
            #region ReportGlobalFields

            private static readonly MySqlConnection Connection = new MySqlConnection();
            private static readonly MySqlCommand QueryCommand = new MySqlCommand();

            #endregion
            public static void InventoryReport(string brId)
            {
                var query = "Select * From Branches";
                Connection.ConnectionString = DAC.CsBuilder.ConnectionString;
                QueryCommand.Connection = Connection;
                QueryCommand.CommandText = query;
                var ds = new DataSet();
                var da = new MySqlDataAdapter(QueryCommand);
                try
                {
                    Connection.Open();
                    da.Fill(ds, "TblBranches");
                }
                catch
                {
                    MessageBox.Show(@"Connection error!");
                }
                finally
                {
                    Connection.Close();
                }
                query =
                    "SELECT * FROM Goods";
                QueryCommand.CommandText = query;
                da = new MySqlDataAdapter(QueryCommand);
                try
                {
                    Connection.Open();
                    da.Fill(ds, "TblGoods");
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Connection error!");
                }
                finally
                {
                    Connection.Close();
                }
                query = AppProperties.User.brID!="9999" ? $"SELECT * FROM Inventory WHERE brID='{brId}'" : "SELECT * FROM Inventory";
                    
                QueryCommand.CommandText = query;
                da = new MySqlDataAdapter(QueryCommand);
                try
                {
                    Connection.Open();
                    da.Fill(ds, "TblInventory");
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Connection error!");
                }
                finally
                {
                    Connection.Close();
                }
                query =
                    "SELECT * FROM Warrants";
                QueryCommand.CommandText = query;
                da = new MySqlDataAdapter(QueryCommand);
                try
                {
                    Connection.Open();
                    da.Fill(ds, "TblWarrants");
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Connection error!");
                }
                finally
                {
                    Connection.Close();
                }
                query =
                    $"SELECT * FROM WarrantsDetails WHERE wrnID IN (SELECT wrnID FROM Warrants WHERE brID='{brId}')";
                QueryCommand.CommandText = query;
                da = new MySqlDataAdapter(QueryCommand);
                try
                {
                    Connection.Open();
                    da.Fill(ds, "TblWarrantsDetails");
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Connection error!");
                }
                finally
                {
                    Connection.Close();
                }
                var report = new StiReport();
                report.Load("Inventory.mrt");
                report.RegData(ds);
                report.Show();
            }

            public static void CardexReport(string brId, string gdId)
            {
                var query = "Select * From Branches";
                Connection.ConnectionString = DAC.CsBuilder.ConnectionString;
                QueryCommand.Connection = Connection;
                QueryCommand.CommandText = query;
                var ds = new DataSet();
                var da = new MySqlDataAdapter(QueryCommand);
                try
                {
                    Connection.Open();
                    da.Fill(ds, "TblBranches");
                }
                catch
                {
                    MessageBox.Show(@"Connection error!");
                }
                finally
                {
                    Connection.Close();
                }
                query = $"SELECT * FROM Goods WHERE gdCode='{gdId}'";
                QueryCommand.CommandText = query;
                da = new MySqlDataAdapter(QueryCommand);
                try
                {
                    Connection.Open();
                    da.Fill(ds, "TblGoods");
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Connection error!");
                }
                finally
                {
                    Connection.Close();
                }
                query = AppProperties.User.brID != "9999"
                    ? $"SELECT * FROM Inventory WHERE brID='{brId}' AND gdCode='{gdId}'"
                    : $"SELECT * FROM Inventory WHERE gdCode='{gdId}'";

                QueryCommand.CommandText = query;
                da = new MySqlDataAdapter(QueryCommand);
                try
                {
                    Connection.Open();
                    da.Fill(ds, "TblInventory");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection error!\n{ex}");
                }
                finally
                {
                    Connection.Close();
                }
                query = $"SELECT * FROM Warrants WHERE brID='{brId}'";
                QueryCommand.CommandText = query;
                da = new MySqlDataAdapter(QueryCommand);
                try
                {
                    Connection.Open();
                    da.Fill(ds, "TblWarrants");
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Connection error!");
                }
                finally
                {
                    Connection.Close();
                }
                query =
                    $"SELECT * FROM WarrantsDetails WHERE wrnID IN (SELECT wrnID FROM Warrants WHERE brID='{brId}') AND gdCode='{gdId}'";
                QueryCommand.CommandText = query;
                da = new MySqlDataAdapter(QueryCommand);
                try
                {
                    Connection.Open();
                    da.Fill(ds, "TblWarrantsDetails");
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Connection error!");
                }
                finally
                {
                    Connection.Close();
                }
                var report = new StiReport();
                report.Load("Cardex.mrt");
                report.RegData(ds);
                report.Show();
            }
        }

        #endregion
    }
}
