using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaharNarenjERP
{
    public partial class FrmProductExtraInfo : Form
    {
        private readonly DataTable _dt = new DataTable();
        private readonly MySqlDataAdapter _da = new MySqlDataAdapter();
        private readonly BindingSource _bs = new BindingSource();

        private readonly string _baseQuery =
            $@"SELECT pc.ConstraintName AS `آپشن`, idt.TextileCode AS `کد پارچه`, t.TextileName AS `نام پارچه` FROM invoicedetailtextile idt INNER JOIN productconstraint pc ON idt.ConstraintId=pc.ConstraintId INNER JOIN textiles t ON idt.TextileCode=t.TextileCode WHERE idt.detId={
                AppProperties.SenderObject2}";

        public FrmProductExtraInfo()
        {
            InitializeComponent();
        }

        private void FrmProductExtraInfo_Load(object sender, EventArgs e)
        {
            try
            {
                LblProduct.Text =
                    DAC.ComboBoxReturn("productName", "products", "productId", AppProperties.PrCode).ToString();
                DAC.ListBoxFill("productconstraint", "ConstraintName", "ConstraintId", "ConstraintId", LstOptions,
                    "IsTextile=1");
                DAC.ListBoxFill("textiles", "TextileName", "QualityCode", "TextileCode", LstOptionValues);
                BLL.DataIfC.DataBind(DgvCurrentOptions, _dt, _da, _bs, _baseQuery);
                DgvSetUp();
                StLblInfo.Text = DgvCurrentOptions.Rows.Count - 1 + @" ردیف";
            }
            catch (Exception exception)
            {
                StLblInfo.Text = @"خطا در ارتباط با پایگاه داده";
                BLL.LogWriter(exception.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvSetUp()
        {
            try
            {
                DgvCurrentOptions.Columns[0].ReadOnly = true;
                //DgvTextile.Columns[0].Frozen = true;
                DgvCurrentOptions.Columns[0].Resizable = DataGridViewTriState.False;
                DgvCurrentOptions.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvCurrentOptions.Columns[1].ReadOnly = true;
                //DgvTextile.Columns[1].Frozen = true;
                DgvCurrentOptions.Columns[1].Resizable = DataGridViewTriState.True;
                DgvCurrentOptions.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //DgvTextile.Columns[1].FillWeight = 300.0f;
                DgvCurrentOptions.Columns[2].ReadOnly = true;
                //DgvTextile.Columns[1].Frozen = true;
                DgvCurrentOptions.Columns[2].Resizable = DataGridViewTriState.True;
                DgvCurrentOptions.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            finally
            {
                DgvCurrentOptions.AlternatingRowsDefaultCellStyle.BackColor = Color.Cornsilk;
            }
        }

        private void TxtTxCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DAC.ListBoxFill("textiles", "TextileName", "QualityCode", "TextileCode", LstOptionValues,
                    $@"textileCode LIKE '%{TxtTxCode.Text}%'");
            }
            catch (Exception exception)
            {
                StLblInfo.Text = @"خطا در ارتباط با پایگاه داده";
                BLL.LogWriter(exception.ToString());
            }
        }

        private void TxtTxName_TextChanged(object sender, EventArgs e)
        {
            var query = _baseQuery + $@" AND textileName LIKE '%{TxtTxName.Text}%'";
            try
            {
                DAC.ListBoxFill("textiles", "TextileName", "QualityCode", "TextileCode", LstOptionValues,
                    $@"textileName LIKE '%{TxtTxName.Text}%'");
            }
            catch (Exception exception)
            {
                StLblInfo.Text = @"خطا در ارتباط با پایگاه داده";
                BLL.LogWriter(exception.ToString());
            }
        }

        private void BtnAddOp_Click(object sender, EventArgs e)
        {
            var q =
                $@"UPDATE invoicedetailtextiles SET TextileCode='{LstOptionValues.SelectedValue}' WHERE detId={
                    AppProperties.SenderObject2} AND ConstraintId={LstOptions.SelectedValue};";
            if (DAC.ExecuteSql(q))
            {
                BLL.DataIfC.DataBind(DgvCurrentOptions, _dt, _da, _bs, _baseQuery);
                DgvSetUp();
                StLblInfo.Text = DgvCurrentOptions.Rows.Count - 1 + @" ردیف";
            }
            else
            {
                q =
                    $@"SELECT detTxtlId FROM invoicedetailtextiles WHERE detId={AppProperties.SenderObject2
                        } AND ConstraintId={LstOptions.SelectedValue}";
                var connection = new MySqlConnection(DAC.CsBuilder.ConnectionString);
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = q;
                BLL.LogWriter($@"به روز رسانی جزئیات پارچه برای idt={cmd.ExecuteScalar().ToString()} با اشکال مواجه شد.");
            }
        }
    }
}
