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
    public partial class FrmProductSearch : Form
    {
        private readonly DataTable _dt = new DataTable();
        private readonly MySqlDataAdapter _da = new MySqlDataAdapter();
        private readonly BindingSource _bs = new BindingSource();

        private const string BaseQuery =
            @"SELECT productID AS `کد کالا`, productName AS `نام کالا` FROM products";

        public FrmProductSearch()
        {
            InitializeComponent();
        }

        private void FrmProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void FrmProductSearch_Load(object sender, EventArgs e)
        {
            try
            {
                BLL.DataIfC.DataBind(DgvProducts, _dt, _da, _bs, BaseQuery);
                DgvSetUp();
                StLblInfo.Text = DgvProducts.Rows.Count - 1 + @" ردیف";
            }
            catch
            {
                StLblInfo.Text = @"خطا در ارتباط با پایگاه داده";
            }
        }
        private void DgvSetUp()
        {
            try
            {
                DgvProducts.Columns[0].ReadOnly = true;
                //DgvProducts.Columns[0].Frozen = true;
                DgvProducts.Columns[0].Resizable = DataGridViewTriState.False;
                DgvProducts.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvProducts.Columns[1].ReadOnly = true;
                //DgvProducts.Columns[1].Frozen = true;
                DgvProducts.Columns[1].Resizable = DataGridViewTriState.True;
                DgvProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //DgvProducts.Columns[1].FillWeight = 300.0f;
            }
            finally
            {
                DgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.Cornsilk;
            }
        }

        private void TxtPrCode_TextChanged(object sender, EventArgs e)
        {
            var query = BaseQuery + $@" WHERE productId LIKE '%{TxtPrCode.Text}%'";
            try
            {
                BLL.DataIfC.DataBind(DgvProducts, _dt, _da, _bs, query);
                DgvSetUp();
                StLblInfo.Text = DgvProducts.Rows.Count - 1 + @" ردیف";
            }
            catch
            {
                StLblInfo.Text = @"خطا در ارتباط با پایگاه داده";
            }
        }

        private void TxtPrName_TextChanged(object sender, EventArgs e)
        {
            var query = BaseQuery + $@" WHERE productName LIKE '%{TxtPrName.Text}%'";
            try
            {
                BLL.DataIfC.DataBind(DgvProducts, _dt, _da, _bs, query);
                DgvSetUp();
                StLblInfo.Text = DgvProducts.Rows.Count - 1 + @" ردیف";
            }
            catch
            {
                StLblInfo.Text = @"خطا در ارتباط با پایگاه داده";
            }
        }

        private void DgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvProducts.CurrentRow == null) return;
                AppProperties.PrCode = DgvProducts.CurrentRow.Cells[0].Value.ToString();
            }
            finally
            {
                Close();
            }
        }
    }
}
