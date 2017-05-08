using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaharNarenjERP
{
    public partial class FrmBranches : Form
    {
        private readonly DataTable _dt = new DataTable();
        private readonly MySqlDataAdapter _da = new MySqlDataAdapter();
        private readonly BindingSource _bs = new BindingSource();

        private const string BaseQuery =
            @"SELECT brID AS `کد نمایندگی`, BranchName AS `نام نمایندگی`, Province AS `استان`, City AS `شهر`, brType AS `نوع نمایندگی` FROM Branches b INNER JOIN Cities c ON c.CityID=b.CityID INNER JOIN Provinces p ON p.provID=c.provID INNER JOIN branchtype bt ON bt.brTypeId=b.brTypeId";
        public FrmBranches()
        {
            InitializeComponent();
        }

        private void FrmBranches_Load(object sender, EventArgs e)
        {
            StLblInfo.Text = @"...";
            DAC.ComboBoxFill("cities", "City", "CityID", CmbCities);
            DAC.ComboBoxFill("branchtype", "brType", "brTypeId", CmbBranchType);
            try
            {
                BLL.DataIfC.DataBind(DgvBranches, _dt, _da, _bs, BaseQuery);
                DgvSetUp();
                StLblInfo.Text = DgvBranches.Rows.Count - 1 + @" ردیف";
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
                DgvBranches.Columns[0].ReadOnly = true;
                //DgvBranches.Columns[0].Frozen = true;
                DgvBranches.Columns[0].Resizable = DataGridViewTriState.False;
                DgvBranches.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvBranches.Columns[1].ReadOnly = true;
                //DgvBranches.Columns[1].Frozen = true;
                DgvBranches.Columns[1].Resizable = DataGridViewTriState.True;
                DgvBranches.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //DgvBranches.Columns[1].FillWeight = 300.0f;
                DgvBranches.Columns[2].ReadOnly = true;
                DgvBranches.Columns[2].Frozen = true;
                DgvBranches.Columns[2].Resizable = DataGridViewTriState.False;
                DgvBranches.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvBranches.Columns[3].ReadOnly = true;
                DgvBranches.Columns[3].Frozen = true;
                DgvBranches.Columns[3].Resizable = DataGridViewTriState.False;
                DgvBranches.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvBranches.Columns[4].ReadOnly = true;
                DgvBranches.Columns[4].Frozen = true;
                DgvBranches.Columns[4].Resizable = DataGridViewTriState.False;
                DgvBranches.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
            finally
            {
                DgvBranches.AlternatingRowsDefaultCellStyle.BackColor = Color.Cornsilk;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var insertQuery =
                $"INSERT INTO Branches VALUES ('{TxtBranchCode.Text}','{TxtBranchName.Text}',{CmbCities.SelectedValue},{CmbBranchType.SelectedValue})";
            var updateQuery =
                $"UPDATE Branches SET brID='{TxtBranchCode.Text}', BranchName='{TxtBranchName.Text}', CityId={CmbCities.SelectedValue}, brTypeId={CmbBranchType.SelectedValue} WHERE brID='{TxtBranchCode.Text}' OR BranchName='{TxtBranchName.Text}'";
            if (DAC.ExecuteSql(insertQuery))
            {
                StLblInfo.Text = @"شعبه جدید با موفقیت ثبت گردید.";
            }
            else if (DAC.ExecuteSql(updateQuery))
            {
                StLblInfo.Text = @"شعبه جاری با موفقیت به روزرسانی شد.";
            }
            else
                StLblInfo.Text = @"خطا در انجام عملیات...";
            try
            {
                BLL.DataIfC.DataBind(DgvBranches, _dt, _da, _bs, BaseQuery);
                DgvSetUp();
                //StLblInfo.Text = DgvBranches.Rows.Count - 1 + @" ردیف";
            }
            catch
            {
                StLblInfo.Text = @"خطا در ارتباط با پایگاه داده";
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show(@"آیا از حذف رکورد مطمئن هستید؟", @"هشدار", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            if (dr == DialogResult.No) return;
            try
            {
                StLblInfo.Text = DAC.ExecuteSql($"DELETE FROM Branches WHERE brID={TxtBranchCode.Text}")
                    ? "شعبه جاری با موفقیت حذف گردید."
                    : "خطا در حذف رکورد...";
                BLL.DataIfC.DataBind(DgvBranches, _dt, _da, _bs, BaseQuery);
                DgvSetUp();
            }
            catch
            {
                StLblInfo.Text = @"خطا در ارتباط با پایگاه داده";
            }
        }

        private void DgvBranches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtBranchCode.Text = (sender as DataGridView)?.CurrentRow?.Cells[0].Value.ToString();
                TxtBranchName.Text = (sender as DataGridView)?.CurrentRow?.Cells[1].Value.ToString();
                CmbCities.Text= (sender as DataGridView)?.CurrentRow?.Cells[3].Value.ToString();
                CmbBranchType.Text = (sender as DataGridView)?.CurrentRow?.Cells[4].Value.ToString();
                //var val1 = DgvBranches.CurrentRow?.Cells[3].Value.ToString();
                //if (val1 != null)
                //    CmbCities.SelectedIndex = CmbCities.Items.IndexOf(val1);
                //var value = DgvBranches.CurrentRow?.Cells[4].Value.ToString();
                //if (value != null)
                //    CmbBranchType.SelectedIndex = CmbBranchType.Items.IndexOf(value);
            }
            catch
            {
                //ignored
            }
        }
    }
}
