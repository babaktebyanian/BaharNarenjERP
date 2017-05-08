using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaharNarenjERP.Properties;
using MySql.Data.MySqlClient;

namespace BaharNarenjERP
{
    public partial class FrmImages : Form
    {
        private readonly DataTable _dt = new DataTable();
        private readonly MySqlDataAdapter _da = new MySqlDataAdapter();
        private readonly BindingSource _bs = new BindingSource();
        private string _imageId;

        private const string BaseQuery = @"SELECT ImageId AS `کد تصویر`, Image AS `تصویر`, ImageDesc AS `شرح` FROM Images";
        public FrmImages()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void FrmImages_Load(object sender, EventArgs e)
        {
            if (AppProperties.ModalAccess)
            {
                TxtImageDesc.Enabled = false;
                PbxImage.Enabled = false;
                BtnClose.Visible = false;
                BtnDelete.Visible = false;
                BtnInsert.Visible = false;
            }
            try
            {
                BLL.DataIfC.DataBind(DgvImages, _dt, _da, _bs, BaseQuery);
                DgvSetUp();
                StsLblInfo.Text = DgvImages.Rows.Count + @" ردیف";
            }
            catch
            {
                StsLblInfo.Text = @"خطا در ارتباط با پایگاه داده";
            }
        }

        private void DgvSetUp()
        {
            try
            {
                DgvImages.Columns[0].ReadOnly = true;
                DgvImages.Columns[0].Frozen = true;
                DgvImages.Columns[0].Resizable = DataGridViewTriState.False;
                DgvImages.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvImages.Columns[1].ReadOnly = true;
                DgvImages.Columns[1].Frozen = true;
                DgvImages.Columns[1].ValueType = typeof (Image);
                DgvImages.Columns[1].Width = 50;
                DgvImages.RowTemplate.Height = 50;
                DgvImages.Columns[1].Resizable = DataGridViewTriState.False;
                DgvImages.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvImages.Columns[2].ReadOnly = true;
                //DgvImages.Columns[2].Frozen = true;
                DgvImages.Columns[2].Resizable = DataGridViewTriState.True;
                DgvImages.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                foreach (DataGridViewColumn column in DgvImages.Columns)
                {
                    try
                    {
                        var col = (DataGridViewImageColumn) column;
                        col.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        //column.Description = "Zoomed";
                        col.Dispose();
                    }
                    catch
                    {
                        //ignored
                    }
                }
                
            }
            finally
            {
                //DgvImages.AlternatingRowsDefaultCellStyle.BackColor = Color.Cornsilk;
            }
        }

        private void PbxImage_MouseEnter(object sender, EventArgs e)
        {
            PbxImage.BorderStyle = BorderStyle.Fixed3D;
            PbxImage.Cursor = Cursors.Hand;
        }

        private void PbxImage_MouseLeave(object sender, EventArgs e)
        {
            PbxImage.BorderStyle = BorderStyle.FixedSingle;
            PbxImage.Cursor = Cursors.Default;
        }

        private void PbxImage_Click(object sender, EventArgs e)
        {
            PbxImage.BorderStyle = BorderStyle.None;
            if (OfdImage.ShowDialog() == DialogResult.OK)
            {
                PbxImage.Image = new Bitmap(OfdImage.FileName);
                TxtImageAddress.Text = OfdImage.FileName;
            }
            PbxImage.BorderStyle = BorderStyle.FixedSingle;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            const string sql = @"INSERT INTO IMAGES (ImageDesc, Image) VALUES (@Description, @file)";
            using (var con = new MySqlConnection(DAC.CsBuilder.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Description", TxtImageDesc.Text);
                        var converter = new ImageConverter();
                        var imgArray = (byte[])converter.ConvertTo(PbxImage.Image, typeof(byte[]));
                        cmd.Parameters.AddWithValue("@file", imgArray);
                        //cmd.Parameters.AddWithValue("@file", File.ReadAllBytes(TxtImageAddress.Text));
                        cmd.ExecuteNonQuery();
                        StsLblInfo.ForeColor = Color.Green;
                        StsLblInfo.Text = @"تصویر با موفقیت ذخیره گردید.";
                        Application.DoEvents();
                        Thread.Sleep(1500);
                        FrmImages_Load(sender, e);
                    }
                }
                catch
                {
                    StsLblInfo.ForeColor = Color.Red;
                    StsLblInfo.Text = @"ذخیره سازی تصویر شکست خورد.";
                }
            }
        }

        private void DgvImages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _imageId = (sender as DataGridView)?.CurrentRow?.Cells[0].Value.ToString();
                var currentRow = (sender as DataGridView)?.CurrentRow;
                if (currentRow != null)
                {
                    var bytes = (byte[])(currentRow.Cells[1].Value);
                    using (var byteStream = new MemoryStream(bytes))
                    {
                        PbxImage.Image = new Bitmap(byteStream);
                    }

                }
                TxtImageDesc.Text = (sender as DataGridView)?.CurrentRow?.Cells[2].Value.ToString();
            }
            catch
            {
                //ignored
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var sql = $@"DELETE FROM Images WHERE ImageId={_imageId}";
            using (var con = new MySqlConnection(DAC.CsBuilder.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                        StsLblInfo.ForeColor = Color.DarkOrange;
                        StsLblInfo.Text = @"تصویر با موفقیت حذف گردید.";
                        Application.DoEvents();
                        Thread.Sleep(1500);
                        FrmImages_Load(sender, e);
                    }
                }
                catch
                {
                    StsLblInfo.ForeColor = Color.Red;
                    StsLblInfo.Text = @"ذخیره سازی تصویر شکست خورد.";
                }
            }
        }

        private void DgvImages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!AppProperties.ModalAccess) return;
            var dataGridViewRow = (sender as DataGridView)?.CurrentRow;
            if (dataGridViewRow != null)
                AppProperties.SenderObject = dataGridViewRow?.Cells[0].Value.ToString();
            Dispose();
            Close();
        }
    }
}
