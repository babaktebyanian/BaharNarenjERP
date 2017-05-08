using System;
using System.Globalization;
using System.Windows.Forms;

namespace BaharNarenjERP
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AppProperties.ForceClose = true;
            Application.Exit();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            try
            {
                BLL.LogIn.ComboFill(cmbUserName);
            }
            catch
            {
                MessageBox.Show(@"ارتباط با پایگاه داده مقدور نیست.", @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            
            //if (txtPassEntry.Text != AppProperties.MaserPassword) return;
            //var frm = new FrmSettings { Icon = Icon };
            //frm.ShowDialog(this);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassEntry.Text == AppProperties.MasterPassword)
            {
                AppProperties.MasterEntrance = true;
                AppProperties.User.persFName = "Master";
                AppProperties.User.brID = "9999";
                AppProperties.User.persLName = "Entrance";
                Close();
                return;
            }
            try
            {
                var passkey = DAC.ComboBoxReturn("Password", "Users", "userID", cmbUserName.Text).ToString();
                var salt = passkey.Substring(0, 8);
                if (passkey == (salt + Security.SaltedHash(txtPassEntry.Text, salt)))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show(@"نام کاربر یا گذرواژه اشتباه است", @"هشدار", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    txtPassEntry.Focus();
                    txtPassEntry.Text = "";
                }
            }
            catch
            {
                MessageBox.Show(@"نام کاربر یا گذرواژه اشتباه است", @"هشدار", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                txtPassEntry.Focus();
                txtPassEntry.Text = "";
            }
            //Close();
        }

        private void FrmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppProperties.MasterEntrance) return;
            try
            {
                var passkey = DAC.ComboBoxReturn("passWord", "Users", "userID", cmbUserName.Text).ToString();
                var salt = passkey.Substring(0, 8);
                if (passkey != (salt + Security.SaltedHash(txtPassEntry.Text, salt)))
                {
                    Application.Exit();
                }
                BLL.Globals.SetUser(cmbUserName.Text);
            }
            catch
            {
                Application.Exit();
            }
        }

        private void cmbUserName_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
