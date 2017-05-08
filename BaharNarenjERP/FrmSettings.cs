using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaharNarenjERP
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            TxtPort.Text = Properties.Settings.Default.Port.ToString();
            TxtDeliveryDifference.Text = Properties.Settings.Default.DeliveryDifference.ToString();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = TxtServer.Text;
            Properties.Settings.Default.Port = Convert.ToUInt32(TxtPort.Text);
            Properties.Settings.Default.UserID = TxtUserId.Text;
            Properties.Settings.Default.Password = TxtPassword.Text;
            Properties.Settings.Default.DataBase = TxtDatebase.Text;
            Properties.Settings.Default.CompanyName = TxtCompanyName.Text;
            Properties.Settings.Default.EndNote = TxtEndNote.Text;
            Properties.Settings.Default.TimeServer = TxtTimeServer.Text;
            Properties.Settings.Default.DeliveryDifference = Convert.ToInt32(TxtDeliveryDifference.Text);
            Properties.Settings.Default.Save();
        }

        private void BtnConTest_Click(object sender, EventArgs e)
        {
            var cn = new MySqlConnection(new MySqlConnectionStringBuilder
            {
                Server = TxtServer.Text,
                Port = Convert.ToUInt32(TxtPort.Text),
                UserID = TxtUserId.Text,
                Password = TxtPassword.Text,
                Database = TxtDatebase.Text
            }.ConnectionString);
            DAC.TestConnection(cn);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            BtnApply_Click(sender, e);
            Close();
        }

    }
}
