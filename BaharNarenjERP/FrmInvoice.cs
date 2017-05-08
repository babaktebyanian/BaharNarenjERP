using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using AmirCalendar;
using MySql.Data.MySqlClient;

namespace BaharNarenjERP
{
    public partial class FrmInvoice : Form
    {
        List<string> queriesG = new List<string>();
        List<MySqlCommand> commandsG = new List<MySqlCommand>();
        MySqlConnection connectionG = new MySqlConnection(DAC.CsBuilder.ConnectionString);
        private MySqlTransaction trG;
        private MySqlCommand cmdG;
        private string newInvDetId;
        private bool txOps = false;

        private readonly DataTable _dt = new DataTable();
        private readonly MySqlDataAdapter _da = new MySqlDataAdapter();
        private readonly BindingSource _bs = new BindingSource();

        private readonly string _baseQuery =
            "SELECT id.productId AS `کد کالا`, p.productName AS `نام کالا`, id.Count AS `تعداد`, (p.unitPrice*id.Count-id.discountTotal) AS `قیمت`, id.discountTotal AS `تخفیف`, id.AddedCost AS `افزاینده`, id.InBranch AS `موجودی شعبه`, id.Description AS `توضیحات` FROM invoicedetails id INNER JOIN products p ON id.productId=p.productId";
        public FrmInvoice()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var ts = FclDeliveryDate.Value.GregorianSelectedDate - FclInvoiceDate.Value.GregorianSelectedDate;
            if (ts < (new TimeSpan(14, 0, 0, 0)))
            {
                var dr =
                    MessageBox.Show(@"زمان تحویل کمتر از میزان مجاز است. آیا مطمئن هستید که می خواهید همین زمان را برای تحویل ثبت کنید؟
در صورت عدم رعایت فاصله زمانی مجاز برای تحویل محصول، این مسئله ثبت می گردد و به اطلاع مرجع مربوطه خواهد رسید.", @"هشدار",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Hand,
                        MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                if (dr == DialogResult.No) return;
                //Do something here
            }
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            BLL.AllowNumbersOnly(e);
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            TxtEmail.BackColor = Color.White;
            InputLanguage.CurrentInputLanguage =
                InputLanguage.FromCulture(CultureInfo.CreateSpecificCulture("fa-IR"));
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            //RdBtncustomerDelivery.Checked = true;
            TxtInvNo.Focus();
            TxtBranchName.Text = AppProperties.User.brName;
            FclWedDate.Enabled = false;
            var query =
                $"SELECT p.persId AS `ID`, CONCAT_WS(' ',p.persFName,p.persLName) AS `Name` FROM Personnel p INNER JOIN PersBranch pb ON pb.persId=p.persId WHERE pb.brId='{AppProperties.User.brID}' ORDER BY Name ASC";
            DAC.ComboStraightNameFill(query, "Personnel", CmbSalesPerson);
            //var name = AppProperties.User.persFName + " " + AppProperties.User.persLName;
            //CmbSalesPerson.SelectedIndex = CmbSalesPerson.Items.IndexOf(name);
            CmbSalesPerson.SelectedValue = AppProperties.User.persID;
            LblCustId.Text = @"...";
            DAC.ComboBoxFill("Educations", "Education", "EduID", CmbEducation);
            DAC.ComboBoxFill("Professions", "ProfName", "ProfID", CmbProfessions);
            DAC.ComboBoxFill("Acquaintances", "AcqType", "AcqID", CmbAcq);
            DAC.ComboBoxFill("Provinces", "Province", "ProvID", CmbProvince);
            CmbEducation.SelectedIndex = 0;
            CmbProfessions.SelectedIndex = 0;
            CmbAcq.SelectedIndex = 0;
            CmbProvince.SelectedIndex = 0;
            CmbProvince_SelectedIndexChanged(sender, e);
            CmbGender.SelectedIndex = 0;
            FclInvoiceDate.Value.FarsiSelectedDate = BLL.Today;
            //var ts = new TimeSpan(Properties.Settings.Default.DeliveryDifference, 0, 0, 0);
            var deliveryDate = FclInvoiceDate.Value.GregorianSelectedDate +
                               new TimeSpan(Properties.Settings.Default.DeliveryDifference, 0, 0, 0);
            FclDeliveryDate.Value.FarsiSelectedDate = BLL.PersianDate(deliveryDate);
            DAC.ComboBoxFill("Products", "productName", "productId", CmbProduct);
            DAC.ComboBoxFill("prepaymenttypes", "prePayType", "prePayTypeId", CmbPrePayType);
            
        }
        private void DgvSetUp()
        {
            try
            {
                DgvInvoice.Columns[0].ReadOnly = true;
                //DgvInvoice.Columns[0].Frozen = true;
                DgvInvoice.Columns[0].Resizable = DataGridViewTriState.False;
                DgvInvoice.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DgvInvoice.Columns[1].ReadOnly = true;
                //DgvInvoice.Columns[1].Frozen = true;
                DgvInvoice.Columns[1].Resizable = DataGridViewTriState.True;
                DgvInvoice.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DgvInvoice.Columns[2].ReadOnly = true;
                //DgvInvoice.Columns[2].Frozen = true;
                DgvInvoice.Columns[2].Resizable = DataGridViewTriState.False;
                DgvInvoice.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                DgvInvoice.Columns[3].ReadOnly = true;
                //DgvInvoice.Columns[3].Frozen = true;
                DgvInvoice.Columns[3].Resizable = DataGridViewTriState.False;
                DgvInvoice.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DgvInvoice.Columns[4].ReadOnly = true;
                //DgvInvoice.Columns[4].Frozen = true;
                DgvInvoice.Columns[4].Resizable = DataGridViewTriState.False;
                DgvInvoice.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                DgvInvoice.Columns[5].ReadOnly = true;
                //DgvInvoice.Columns[5].Frozen = true;
                DgvInvoice.Columns[5].Resizable = DataGridViewTriState.False;
                DgvInvoice.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                DgvInvoice.Columns[6].ReadOnly = true;
                //DgvInvoice.Columns[6].Frozen = true;
                DgvInvoice.Columns[6].Resizable = DataGridViewTriState.False;
                DgvInvoice.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                DgvInvoice.Columns[7].ReadOnly = true;
                //DgvInvoice.Columns[7].Frozen = true;
                DgvInvoice.Columns[7].Resizable = DataGridViewTriState.False;
                DgvInvoice.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
            finally
            {
                DgvInvoice.AlternatingRowsDefaultCellStyle.BackColor = Color.Cornsilk;
            }
        }
        private void BtnCustRegister_Click(object sender, EventArgs e)
        {
            if (TxtEmail.Text.Trim() != "" && !BLL.RegexUtilities.IsValidEmail(TxtEmail.Text))
            {
                MessageBox.Show(@"ایمیل به صورت درست وارد نشده است.", @"هشدار", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                TxtEmail.BackColor = Color.Salmon;
                TxtEmail.SelectAll();
                TxtEmail.Focus();
                return;
            }
            var queries = new List<string>();
            var birth = BLL.PersianDate(FclBirthDate.Value.GregorianSelectedDate);
            var wed = ChkMarried.Checked
                ? BLL.PersianDate(FclWedDate.Value.GregorianSelectedDate)
                : null;
            var commands = new List<MySqlCommand>();
            var connection = new MySqlConnection(DAC.CsBuilder.ConnectionString);
            connection.Open();
            var tr = connection.BeginTransaction();
            var cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Transaction = tr;
            try
            {
                var query =
                    $"INSERT INTO Customers (CustFName, CustLName, NatCode, BirthDate, WeddingDate, Gender, Comment) VALUES ('{TxtCustName.Text}', '{TxtCustFname.Text}', '{TxtNatCode.Text}', '{birth}', '{wed}', {CmbGender.SelectedIndex}, '{TxtCustComment.Text}');";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                const string sql = "SELECT Item FROM TempItems Where ItemID = 1";
                cmd.CommandText = sql;
                var codeReturn = cmd.ExecuteScalar();
                var newCustId = codeReturn.ToString();
                query =
                    $@"INSERT INTO Addresses (CityID, Address, customerID) VALUES ({CmbCity.SelectedValue}, '{
                        TxtAddress.Text}', {newCustId});";
                queries.Add(query);
                query =
                    $@"INSERT INTO Phones (Code, Phone, CustomerID) VALUES ('{TxtPhoneCode.Text}', '{
                        TxtPhone.Text}', {newCustId});";
                queries.Add(query);
                query =
                    $@"INSERT INTO Mobiles (Mobile, CustomerID) VALUES ('{TxtMobile.Text}', {newCustId});";
                queries.Add(query);
                query = $@"INSERT INTO Emails (Email, CustomerID) VALUES ('{TxtEmail.Text}', {newCustId});";
                queries.Add(query);
                query = $@"INSERT INTO CustAcq (CustomerID, AcqID) VALUES ({newCustId}, {CmbAcq.SelectedValue});";
                queries.Add(query);
                query = $@"INSERT INTO CustEdu (CustomerID, EduID) VALUES ({newCustId}, {CmbEducation.SelectedValue});";
                queries.Add(query);
                query = $@"INSERT INTO CustProf (CustomerID, ProfID) VALUES ({newCustId}, {CmbProfessions.SelectedValue});";
                queries.Add(query);

                foreach (var item in queries)
                {
                    var cmd2 = connection.CreateCommand();
                    cmd2.CommandText = item;
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Transaction = tr;
                    commands.Add(cmd2);
                }
                foreach (var item in commands)
                {
                    item.ExecuteNonQuery();
                }
                tr.Commit();
                connection.Close();
                LblCustId.Text = DAC.ComboBoxReturn("Item", "TempItems", "ItemID", 1).ToString();
                GbxInvoice.Enabled = true;
                GbxCustInfo.Enabled = false;
            }
            catch (Exception exception)
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
                LblCustId.Text = @"...";
                BLL.LogWriter(exception.ToString());
            }
            connectionG = new MySqlConnection(DAC.CsBuilder.ConnectionString);
            connectionG.Open();
            trG = connectionG.BeginTransaction();
            cmdG = connectionG.CreateCommand();
            cmdG.CommandType = CommandType.Text;
            cmdG.Transaction = trG;
            try
            {
                var q =
                    $@"INSERT INTO invoices (CustomerID, orderDate, deliveryDate, SalespersonId) VALUES ({LblCustId}, '{
                        FclInvoiceDate.Value.FarsiSelectedDate}','{FclDeliveryDate.Value.FarsiSelectedDate}', '{
                        CmbSalesPerson.SelectedValue}');";
                cmdG.CommandText = q;
                cmdG.ExecuteNonQuery();
                const string sql2 = "SELECT Item FROM TempItems Where ItemID = 2";
                cmdG.CommandText = sql2;
                var newInvoiveNo = cmdG.ExecuteScalar().ToString();
                TxtInvNo.Text = newInvoiveNo;
                try
                {
                    q = $@"{_baseQuery} WHERE id.invNo={newInvoiveNo}";
                    BLL.DataIfC.DataBind(DgvInvoice, _dt, _da, _bs, q);
                    DgvSetUp();
                    LblRows.Text = DgvInvoice.Rows.Count - 1 + @" ردیف";
                }
                catch (Exception exception)
                {
                    BLL.LogWriter(exception.ToString());
                }

                //trG.Commit();
                //connectionG.Close();
            }
            catch (Exception exception)
            {
                BLL.LogWriter(exception.ToString());
            }
        }

        private void ChkWedDate_CheckedChanged(object sender, EventArgs e)
        {
            FclWedDate.Enabled = ChkMarried.Checked;
        }

        private void CmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //var prvId = DAC.ComboBoxReturn("ProvID", "Provinces", "Province", CmbProvince.Text).ToString();
                DAC.ComboBoxFill("Cities", "City", "CityID", CmbCity, $@"ProvID={CmbProvince.SelectedValue}");
            }
            catch
            {
                //ignored
            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage =
                InputLanguage.FromCulture(CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void BtnPrSearch_Click(object sender, EventArgs e)
        {
            (new FrmProductSearch()).ShowDialog();
            TxtPrCode.Text = AppProperties.PrCode;
            TxtPrCode_TextChanged(sender, e);
            TextileOps(sender, e, txOps);
        }

        private void TextileOps(object sender, EventArgs e, bool done)
        {
            try
            {
                if (done) return;
                var connection = new MySqlConnection(DAC.CsBuilder.ConnectionString);
                connection.Open();
                //var tr = connection.BeginTransaction();
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.Transaction = tr;
                var q =
                    $@"Select needTextile FROM productcategories pc INNER JOIN products p ON pc.prodcatid=p.prodcatid WHERE p.productid='{
                        TxtPrCode.Text}';";
                cmd.CommandText = q;
                var nt = cmd.ExecuteScalar().ToString();
                var needTextile = Convert.ToInt32(nt) == 1 ? true : false;
                BtnOptions.Enabled = needTextile;
                //if (needTextile) BtnTextileSearch_Click(sender, e);
                var ib = Convert.ToUInt32(ChkInBranch.Checked);
                q =
                    $@"INSERT INTO InvoiceDetails (invNo, ProductId, Count, LayId, discount, Inbranch) VALUES ('{
                        TxtInvNo.Text}', '{TxtPrCode.Text}', {TxtCount.Text}, {CmbLayout.SelectedValue}, {
                        TxtDiscountPercent.Text}, {ib});";
                cmdG.CommandText = q;
                cmdG.ExecuteNonQuery();
                q = "SELECT Item FROM TempItems Where ItemID = 3";
                cmdG.CommandText = q;
                newInvDetId = cmdG.ExecuteScalar().ToString();
                AppProperties.SenderObject2 = newInvDetId;
                if (needTextile)
                {
                    BtnTextileSearch_Click(sender, e);
                    cmdG.CommandType = CommandType.StoredProcedure;
                    cmdG.CommandText = $@"AddTextileToInvoiceDetail({newInvDetId}, '{AppProperties.SenderString}');";
                    cmdG.ExecuteNonQuery();
                    cmdG.CommandType = CommandType.Text;
                    AppProperties.PrCode = TxtPrCode.Text;
                    BtnOptions_Click(sender, e);
                }
                txOps = true;
            }
            catch (Exception ex)
            {
                try
                {
                    txOps = false;
                    BLL.LogWriter(ex.ToString());
                    trG.Rollback();
                }
                catch (Exception exception)
                {
                    BLL.LogWriter(exception.ToString());
                }
            }
        }

        private void TxtPrCode_TextChanged(object sender, EventArgs e)
        {
            DAC.ComboBoxFill("Products", "productName", "productId", CmbProduct, $@"productId LIKE '%{TxtPrCode.Text}%'");
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtPrCode.Text = CmbProduct.SelectedValue.ToString();
        }

        private void BtnAddDetail_Click(object sender, EventArgs e)
        {
            //connectionG = new MySqlConnection(DAC.CsBuilder.ConnectionString);
            //connectionG.Open();
            //trG = connectionG.BeginTransaction();
            //cmdG = connectionG.CreateCommand();
            //cmdG.CommandType = CommandType.Text;
            //cmdG.Transaction = trG;
            TextileOps(sender, e, txOps);
            txOps = false;
        }

        private static void BtnTextileSearch_Click(object sender, EventArgs e)
        {
            (new FrmTextileSearch()).ShowDialog();
            
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            (new FrmProductExtraInfo()).ShowDialog();
        }

        private void TxtCount_Enter(object sender, EventArgs e)
        {
            TextileOps(sender, e, txOps);
        }

        private void TxtPrCode_Leave(object sender, EventArgs e)
        {
            TextileOps(sender, e, txOps);
        }

        private void CmbProduct_Leave(object sender, EventArgs e)
        {
            TextileOps(sender, e, txOps);
        }
        
        private void DgvInvoice_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (var i = 0; i < e.RowCount; i++)
                DgvInvoice.Rows[e.RowIndex + i].Cells[0].Value = (e.RowIndex + i).ToString();
        }

        private void TxtNatCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            BLL.AllowNumbersOnly(e);
        }
    }
}
