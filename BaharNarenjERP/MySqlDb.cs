using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaharNarenjERP
{
    public static class DAC
    {
        private static MySqlConnectionStringBuilder _csBuilder = new MySqlConnectionStringBuilder();

        public static MySqlConnectionStringBuilder CsBuilder
        {
            get
            {
                _csBuilder.Server = AppProperties.ConStr.Server;
                _csBuilder.Port = AppProperties.ConStr.Port;
                _csBuilder.UserID = AppProperties.ConStr.UserID;
                _csBuilder.Password = AppProperties.ConStr.Password;
                _csBuilder.Database = AppProperties.ConStr.DataBase;
                return _csBuilder;
            }
            set { _csBuilder = value; }
        }

        private static MySqlConnection Connection => new MySqlConnection(CsBuilder.ConnectionString);

        public static void TestConnection(MySqlConnection c)
        {
            try
            {
                c.Open();
                MessageBox.Show(@"اتصال به پایگاه داده با موفقیت انجام شد.", @"اتصال به سرور", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            catch
            {
                MessageBox.Show(@"اتصال به پایگاه داده با شکست مواجه شد.", @"اتصال به سرور", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            finally
            {
                try
                {
                    c.Close();
                }
                catch
                {
                    // ignored
                }
            }
        }

        public static bool DoTransaction(IEnumerable<string> queries1, IEnumerable<string> queries2)
        {
            var commands1 = new List<MySqlCommand>();
            var commands2 = new List<MySqlCommand>();
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            connection.Open();
            var tr = connection.BeginTransaction();
            foreach (var item in queries1)
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = item;
                cmd.CommandType = CommandType.Text;
                cmd.Transaction = tr;
                commands1.Add(cmd);
            }
            foreach (var item in queries2)
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = item;
                cmd.CommandType = CommandType.Text;
                cmd.Transaction = tr;
                commands2.Add(cmd);
            }
            try
            {
                foreach (var item in commands1)
                {
                    item.ExecuteNonQuery();
                }
                foreach (var item in commands2)
                {
                    item.ExecuteNonQuery();
                }
                tr.Commit();
                connection.Close();
                return true;
            }
            catch
            {
                try
                {
                    tr.Rollback();
                }
                catch
                {
                    // ignored
                }
                connection.Close();
                return false;
            }
        }

        public static bool DoTransaction(IEnumerable<string> queries1)
        {
            var commands = new List<MySqlCommand>();
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            connection.Open();
            var tr = connection.BeginTransaction();
            foreach (var item in queries1)
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = item;
                cmd.CommandType = CommandType.Text;
                cmd.Transaction = tr;
                commands.Add(cmd);
            }
            try
            {
                foreach (var item in commands)
                {
                    item.ExecuteNonQuery();
                }
                tr.Commit();
                connection.Close();
                return true;
            }
            catch
            {
                try
                {
                    tr.Rollback();
                }
                catch
                {
                    // ignored
                }
                connection.Close();
                return false;
            }
        }

        public static bool ExecuteSql(string sql)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                //var cmd = new MySqlCommand { CommandText = sql, CommandType=CommandType.Text, Connection = connection };
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                //cmd.CommandTimeout = 60;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void MessageShow(bool ok, string s1, string s2)
        {
            MessageBox.Show(ok ? s1 : s2, @"پیام", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        public static void MessageShow(bool ok, string s1)
        {
            if (ok) return;
            MessageBox.Show(s1, @"هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }
        /// <summary>
        /// Old Binding Method.
        /// </summary>
        /// <param name="dg1"></param>
        /// <param name="sql"></param>
        public static void DataGridFill(DataGridView dg1, string sql)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var ds = new DataSet();
                var da = new MySqlDataAdapter(sql, connection);
                da.Fill(ds, "TableData");
                dg1.DataSource = ds.Tables["TableData"];
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// New Binding Method.
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="da"></param>
        /// <param name="bs"></param>
        /// <param name="selectQuery"></param>
        public static void DataBind(DataTable dt, MySqlDataAdapter da, BindingSource bs, string selectQuery)
        {
            dt.Clear();
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = selectQuery;
                command.CommandType = CommandType.Text;
                da.SelectCommand = command;
                new MySqlCommandBuilder(da);
                da.Fill(dt);
                bs.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                //AppProperties.SenderObject = new MySqlCommandBuilder(da).GetInsertCommand().CommandText;
                //AppProperties.SenderString = new MySqlCommandBuilder(da).GetUpdateCommand().CommandText;
                //AppProperties.SenderObject2 = new MySqlCommandBuilder(da).GetDeleteCommand().CommandText;
            }
        }

        public static BindingSource DataBind(string selectQuery)
        {
            var dt = new DataTable();
            var da = new MySqlDataAdapter();
            var bs = new BindingSource();
            dt.Clear();
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = selectQuery;
                command.CommandType = CommandType.Text;
                da.SelectCommand = command;
                new MySqlCommandBuilder(da);
                da.Fill(dt);
                bs.DataSource = dt;
                return bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="da"></param>
        /// <param name="selectQuery">SQL SELECT Command</param>
        /// <param name="insertQuery">SQL INSERT Command</param>
        /// <param name="updateQuery">SQL UPDATE Command</param>
        /// <param name="deleteQuery">SQL DELETE Command</param>
        public static BindingSource DataBind(MySqlDataAdapter da, DataTable dt, string selectQuery, string insertQuery, string updateQuery, string deleteQuery)
        {
            dt.Clear();
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            var bs = new BindingSource();
            try
            {
                connection.Open();
                var selectcommand = connection.CreateCommand();
                selectcommand.CommandText = selectQuery;
                selectcommand.CommandType = CommandType.Text;
                da.SelectCommand = selectcommand;
                var insertcommand = connection.CreateCommand();
                insertcommand.CommandText = insertQuery;
                insertcommand.CommandType = CommandType.Text;
                da.InsertCommand = insertcommand;
                var updatecommand = connection.CreateCommand();
                updatecommand.CommandText = updateQuery;
                updatecommand.CommandType = CommandType.Text;
                da.UpdateCommand = updatecommand;
                var deletecommand = connection.CreateCommand();
                deletecommand.CommandText = deleteQuery;
                deletecommand.CommandType = CommandType.Text;
                da.DeleteCommand = deletecommand;
                //var cb = new MySqlCommandBuilder(da);
                da.Fill(dt);
                bs.DataSource = dt;
                return bs;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString(), @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close();
                //AppProperties.SenderObject = new MySqlCommandBuilder(da).GetInsertCommand().CommandText;
                //AppProperties.SenderString = new MySqlCommandBuilder(da).GetUpdateCommand().CommandText;
                //AppProperties.SenderObject2 = new MySqlCommandBuilder(da).GetDeleteCommand().CommandText;
            }

        }
        /// <summary>
        /// Fills a combobox with given parameters.
        /// </summary>
        /// <param name="tableName">Name of the table to be queried.</param>
        /// <param name="fieldName">Table field name to fill the combobox with.</param>
        /// <param name="comboBox1">The combobox to be filled.</param>
        public static bool ComboBoxFill(string tableName, string fieldName, ComboBox comboBox1)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                var ds = new DataSet();
                connection.Open();
                var sql = "SELECT " + fieldName.Trim() + " FROM " + tableName + " ORDER BY " + fieldName;
                var da = new MySqlDataAdapter(sql, connection);
                ds.Clear();
                da.Fill(ds, tableName);
                connection.Close();
                comboBox1.DataSource = ds.Tables[0].DefaultView;
                comboBox1.DisplayMember = fieldName;
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Fills a combobox with given parameters.
        /// </summary>
        /// <param name="tableName">Name of the table to be queried.</param>
        /// <param name="fieldName">Table field name to fill the combobox with.</param>
        /// <param name="valueField">Table field name that the combobox returns as 'SelectedValue'.</param>
        /// <param name="comboBox1">The combobox to be filled.</param>
        public static void ComboBoxFill(string tableName, string fieldName, string valueField, ComboBox comboBox1)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                var ds = new DataSet();
                connection.Open();
                var sql = $@"SELECT {valueField.Trim()}, {fieldName.Trim()} FROM {tableName} ORDER BY {fieldName}";
                var da = new MySqlDataAdapter(sql, connection);
                ds.Clear();
                da.Fill(ds, tableName);
                connection.Close();
                comboBox1.DataSource = ds.Tables[0].DefaultView;
                comboBox1.DisplayMember = fieldName;
                comboBox1.ValueMember = valueField;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void ComboBoxFill(string tableName, string fieldName, string valueField, ComboBox comboBox1, string cond)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                var ds = new DataSet();
                connection.Open();
                var sql =
                    $@"SELECT {valueField.Trim()}, {fieldName.Trim()} FROM {tableName} WHERE  {cond} ORDER BY {fieldName
                        } ASC;";
                var da = new MySqlDataAdapter(sql, connection);
                ds.Clear();
                da.Fill(ds, tableName);
                connection.Close();
                comboBox1.DataSource = ds.Tables[0].DefaultView;
                comboBox1.DisplayMember = fieldName;
                comboBox1.ValueMember = valueField;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ComboFullNameFill(string tableName, string fName, string lName, string valueField, ComboBox comboBox1)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                var ds = new DataSet();
                connection.Open();
                var sql = "SELECT " + valueField.Trim() + ", CONCAT_WS(', ', " + lName.Trim() + ", " + fName.Trim() +
                          ") AS `Name` FROM " + tableName + " ORDER BY Name ASC";
                var da = new MySqlDataAdapter(sql, connection);
                ds.Clear();
                da.Fill(ds, tableName);
                connection.Close();
                comboBox1.DataSource = ds.Tables[0].DefaultView;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = valueField;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void ComboStraightNameFill(string tableName, string fName, string lName, ComboBox comboBox1)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                var ds = new DataSet();
                connection.Open();
                var sql = "SELECT (" + fName.Trim() + "+' '+" + lName.Trim() + ") AS `Name` FROM " + tableName + " ORDER BY Name ASC";
                var da = new MySqlDataAdapter(sql, connection);
                ds.Clear();
                da.Fill(ds, tableName);
                connection.Close();
                comboBox1.DataSource = ds.Tables[0].DefaultView;
                comboBox1.DisplayMember = "Name";
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ComboStraightNameFill(string query, string tableName, ComboBox comboBox)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                var ds = new DataSet();
                connection.Open();
                
                var da = new MySqlDataAdapter(query, connection);
                ds.Clear();
                da.Fill(ds, tableName);
                connection.Close();
                comboBox.DataSource = ds.Tables[0].DefaultView;
                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "ID";
            }
            finally
            {
                connection.Close();
            }
        }
        public static object ComboBoxReturn(string fieldName1, string tableName, string fieldName2, string value)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var sql = "SELECT  " + fieldName1 + " FROM " + tableName + " Where " + fieldName2 + " = '" + value + "'";
                var cmd = new MySqlCommand(sql, connection) { CommandType = CommandType.Text };
                var codeReturn = cmd.ExecuteScalar();
                return codeReturn;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static object ComboBoxReturn(string fieldName1, string tableName, string fieldName2, int value)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var sql = "SELECT  " + fieldName1 + " FROM " + tableName + " Where " + fieldName2 + " = " + value;
                var cmd = new MySqlCommand(sql, connection) { CommandType = CommandType.Text };
                var codeReturn = cmd.ExecuteScalar();
                return codeReturn;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static object FullNameReturn(string fieldName1, string tableName, string fName, string lName, string value)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var sql = "SELECT  " + fieldName1 + " FROM " + tableName + " Where (" + lName.Trim() + "+', '+" + fName.Trim() + ") = '" + value + "'";
                var cmd = new MySqlCommand(sql, connection) { CommandType = CommandType.Text };
                var codeReturn = cmd.ExecuteScalar();
                return codeReturn;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public static object StraightNameReturn(string fieldName1, string tableName, string fName, string lName, string value)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var sql = "SELECT  " + fieldName1 + " FROM " + tableName + " Where (" + fName.Trim() + "+' '+" + lName.Trim() + ") = '" + value + "'";
                var cmd = new MySqlCommand(sql, connection) { CommandType = CommandType.Text };
                var codeReturn = cmd.ExecuteScalar();
                return codeReturn;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public static object StraightNameReturn(string tableName, string fieldName, string value)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var sql = "SELECT  (FName+' '+LName) AS [Name] FROM " + tableName + " Where " + fieldName.Trim() + "='" +
                          value + "'";
                var cmd = new MySqlCommand(sql, connection) { CommandType = CommandType.Text };
                var codeReturn = cmd.ExecuteScalar();
                return codeReturn;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        
        /// <summary>
        /// Bind a ListBox to Straight Name fields in the data source.
        /// </summary>
        /// <param name="tableName">Name of the table to be queried.</param>
        /// <param name="fName">First Name table field.</param>
        /// <param name="lName">Last Name table field.</param>
        /// <param name="listBox">The ListBox to be filled.</param>
        public static void ListBoxStraightNameFill(string tableName, string fName, string lName, ListBox listBox)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                var ds = new DataSet();
                connection.Open();
                var sql = "SELECT (" + fName.Trim() + "+' '+" + lName.Trim() + ") AS [Name] FROM " + tableName + " ORDER BY LName ASC";
                var da = new MySqlDataAdapter(sql, connection);
                ds.Clear();
                da.Fill(ds, tableName);
                connection.Close();
                listBox.DataBindings.Clear();
                listBox.DataSource = ds.Tables[0].DefaultView;
                listBox.DisplayMember = "Name";
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Bind a ListBox to a table field in data source.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <param name="listBox1"></param>
        public static void ListBoxFill(string tableName, string fieldName, ListBox listBox1)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                var ds = new DataSet();
                connection.Open();
                var sql = "SELECT " + fieldName.Trim() + " FROM " + tableName + " ORDER BY " + fieldName;
                var da = new MySqlDataAdapter(sql, connection);
                ds.Clear();
                da.Fill(ds, tableName);
                connection.Close();
                listBox1.DataBindings.Clear();
                listBox1.DataSource = ds.Tables[0].DefaultView;
                listBox1.DisplayMember = fieldName;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Bind a ListBox to a table field in data source.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <param name="sortField"></param>
        /// <param name="valuefield"></param>
        /// <param name="listBox1"></param>
        public static void ListBoxFill(string tableName, string fieldName, string sortField, string valuefield, ListBox listBox1)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                var ds = new DataSet();
                connection.Open();
                var sql = "SELECT " + fieldName.Trim() + " FROM " + tableName + " ORDER BY " + sortField;
                var da = new MySqlDataAdapter(sql, connection);
                ds.Clear();
                da.Fill(ds, tableName);
                connection.Close();
                listBox1.DataBindings.Clear();
                listBox1.DataSource = ds.Tables[0].DefaultView;
                listBox1.DisplayMember = fieldName;
                listBox1.ValueMember = valuefield;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Bind a ListBox to a table field in data source.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <param name="sortField"></param>
        /// <param name="valuefield"></param>
        /// <param name="listBox1"></param>
        /// <param name="cond">SQL WHERE Condition</param>
        public static void ListBoxFill(string tableName, string fieldName, string sortField, string valuefield, ListBox listBox1, string cond)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                var ds = new DataSet();
                connection.Open();
                var sql = $@"SELECT {fieldName.Trim()} FROM {tableName} WHERE {cond} ORDER BY {sortField}";
                var da = new MySqlDataAdapter(sql, connection);
                ds.Clear();
                da.Fill(ds, tableName);
                connection.Close();
                listBox1.DataBindings.Clear();
                listBox1.DataSource = ds.Tables[0].DefaultView;
                listBox1.DisplayMember = fieldName;
                listBox1.ValueMember = valuefield;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Fills a ListBox with a table field in data source without binding it to the table.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <param name="sortField"></param>
        /// <param name="listbox"></param>
        public static void ListBoxFill2(string tableName, string fieldName, string sortField, ListBox listbox)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var sql = "SELECT " + fieldName.Trim() + " FROM " + tableName + " ORDER BY " + sortField;
                var cmd = new MySqlCommand(sql, connection);
                listbox.DataBindings.Clear();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listbox.Items.Add(dr[0].ToString());
                }
                connection.Close();
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ListBoxStraightNameFill2(string tableName, string fName, string lName, ListBox listBox)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var sql = "SELECT (" + fName.Trim() + "+' '+" + lName.Trim() + ") AS [Name] FROM " + tableName + " ORDER BY LName ASC";
                var cmd = new MySqlCommand(sql, connection);
                listBox.DataBindings.Clear();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listBox.Items.Add(dr[0].ToString());
                }
                connection.Close();
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool IsfieldReturned(string fieldName1, string tableName, string fieldName2, string value)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            var sql = "SELECT  " + fieldName1 + " FROM " + tableName + " Where " + fieldName2 + " = '" + value + "'";
            try
            {
                connection.Open();
                var cmd = new MySqlCommand(sql, connection) { CommandType = CommandType.Text };
                var codeReturn = cmd.ExecuteScalar();
                return (codeReturn.ToString()) != "";
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool IsNotFrequent(string tableName, string fieldName, string value)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var sqLcmd = "SELECT * FROM " + tableName + " WHERE " + fieldName + "='" + value + "'";
                var cmd = new MySqlCommand(sqLcmd, connection);
                var dr = cmd.ExecuteReader();
                return !dr.Read();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void MakeViewFrom2Fields(string tableName, string fieldName1, string fieldName2, string pkField, string newField)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var sql = "";
                sql += "DROP VIEW dbo.vw_" + tableName;
                var cmd = new MySqlCommand { CommandText = sql, Connection = connection };
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
            try
            {
                connection.Open();
                var sql = "";
                sql += "CREATE VIEW dbo.vw_" + tableName;
                sql += "\nAS";
                sql += "\nSELECT " + pkField + "," + fieldName1 + "," + fieldName2 + ",(" + fieldName2 + " + '، ' + " + fieldName1 + ") as \"" + newField + "\" FROM Persons";
                var cmd = new MySqlCommand { CommandText = sql, Connection = connection };
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
        public static int RowCount(string tableName)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                var ds = new DataSet();
                connection.Open();
                var sql = "SELECT * FROM " + tableName;
                var da = new MySqlDataAdapter(sql, connection);
                ds.Clear();
                da.Fill(ds, tableName);
                return ds.Tables[0].Rows.Count;
            }
            catch
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }
        public static string RowValue(string tableName, string fieldName, int rowNumber)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            var sql = "SELECT * FROM " + tableName;
            try
            {
                rowNumber--;
                var ds = new DataSet();
                connection.Open();
                var da = new MySqlDataAdapter(sql, connection);
                ds.Clear();
                da.Fill(ds, tableName);
                DataTable dt = ds.Tables[tableName];
                return dt.Rows[rowNumber][fieldName].ToString();
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public static object FieldMax(string fieldName, string tableName)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var sql = "SELECT MAX(" + fieldName + ") FROM " + tableName;
                var cmd = new MySqlCommand(sql, connection) { CommandType = CommandType.Text };
                var codeReturn = cmd.ExecuteScalar();
                return codeReturn;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public static object CountSpecific(string fieldName, string tableName, string value)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var sql = "SELECT  Count(*) FROM " + tableName + " Where " + fieldName + " = '" + value + "'";
                var cmd = new MySqlCommand(sql, connection) { CommandType = CommandType.Text };
                var codeReturn = cmd.ExecuteScalar();
                return codeReturn;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public static object CountSpecific(string fieldName1, string fieldName2, string tableName, string value1, string value2)
        {
            var connection = new MySqlConnection(CsBuilder.ConnectionString);
            try
            {
                connection.Open();
                var sql = "SELECT  Count(*) FROM " + tableName + " Where " + fieldName1 + " = '" + value1 + "' AND " + fieldName2 + " = '" + value2 + "'";
                var cmd = new MySqlCommand(sql, connection) { CommandType = CommandType.Text };
                var codeReturn = cmd.ExecuteScalar();
                return codeReturn;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        

        public static bool TableExists(string table)
        {
            try
            {
                var connection = new MySqlConnection(CsBuilder.ConnectionString);
                connection.Open();
                var exists = connection.GetSchema("Tables", new[] { null, null, table, "TABLE" }).Rows.Count > 0;
                connection.Close();
                return exists;
            }
            catch
            {
                return false;
            }
        }
    }
}
