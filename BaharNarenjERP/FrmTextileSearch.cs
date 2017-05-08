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
    public partial class FrmTextileSearch : Form
    {
        private readonly DataTable _dt = new DataTable();
        private readonly MySqlDataAdapter _da = new MySqlDataAdapter();
        private readonly BindingSource _bs = new BindingSource();

        private const string BaseQuery =
            @"SELECT textileCode AS `کد پارچه`, textileName AS `نام پارچه` FROM textiles WHERE isAvailable=1;";

        public FrmTextileSearch()
        {
            InitializeComponent();
        }

        private void DgvTextile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void FrmTextileSearch_Load(object sender, EventArgs e)
        {
            try
            {
                BLL.DataIfC.DataBind(DgvTextile, _dt, _da, _bs, BaseQuery);
                DgvSetUp();
                StLblInfo.Text = DgvTextile.Rows.Count - 1 + @" ردیف";
            }
            catch (Exception exception)
            {
                StLblInfo.Text = @"خطا در ارتباط با پایگاه داده";
                BLL.LogWriter(exception.ToString());
            }
        }

        private void DgvSetUp()
        {
            try
            {
                DgvTextile.Columns[0].ReadOnly = true;
                //DgvTextile.Columns[0].Frozen = true;
                DgvTextile.Columns[0].Resizable = DataGridViewTriState.False;
                DgvTextile.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvTextile.Columns[1].ReadOnly = true;
                //DgvTextile.Columns[1].Frozen = true;
                DgvTextile.Columns[1].Resizable = DataGridViewTriState.True;
                DgvTextile.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //DgvTextile.Columns[1].FillWeight = 300.0f;
            }
            finally
            {
                DgvTextile.AlternatingRowsDefaultCellStyle.BackColor = Color.Cornsilk;
            }
        }

        private void TxtTxCode_TextChanged(object sender, EventArgs e)
        {
            var query = BaseQuery + $@" AND textileCode LIKE '%{TxtTxCode.Text}%'";
            try
            {
                BLL.DataIfC.DataBind(DgvTextile, _dt, _da, _bs, query);
                DgvSetUp();
                StLblInfo.Text = DgvTextile.Rows.Count - 1 + @" ردیف";
            }
            catch
            {
                StLblInfo.Text = @"خطا در ارتباط با پایگاه داده";
            }
        }

        private void TxtTxName_TextChanged(object sender, EventArgs e)
        {
            var query = BaseQuery + $@" AND textileName LIKE '%{TxtTxName.Text}%'";
            try
            {
                BLL.DataIfC.DataBind(DgvTextile, _dt, _da, _bs, query);
                DgvSetUp();
                StLblInfo.Text = DgvTextile.Rows.Count - 1 + @" ردیف";
            }
            catch
            {
                StLblInfo.Text = @"خطا در ارتباط با پایگاه داده";
            }
        }

        private void DgvTextile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvTextile.CurrentRow == null) return;
                AppProperties.SenderString = DgvTextile.CurrentRow.Cells[0].Value.ToString();
                AppProperties.SenderObject = DgvTextile.CurrentRow.Cells[1].Value.ToString();
            }
            finally
            {
                Close();
            }
        }
    }
}
