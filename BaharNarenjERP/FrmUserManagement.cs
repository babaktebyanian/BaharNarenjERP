using System;
using System.Globalization;
using System.Windows.Forms;

namespace BaharNarenjERP

{
    public partial class FrmUserManagement : Form
    {
        public FrmUserManagement()
        {
            InitializeComponent();
        }

        private void frmPassChange_Load(object sender, EventArgs e)
        {
            try
            {
                BLL.LogIn.ComboFill(CmbUserName);
                DAC.ComboBoxFill("Branches", "BranchName", "brID", CmbBranches);
                DAC.ComboFullNameFill("Personnel", "persFName", "persLName", "persID", CmbPeople);
            }
            catch
            {
                // ignored
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void btnPassChange_Click(object sender, EventArgs e)
        {
            var newPass = txtPassEntry.Text.Trim();
            var repPass = txtPassRepeat.Text.Trim();
            if (DAC.IsNotFrequent("Users", "userID", CmbUserName.Text))
            {
                MessageBox.Show(@"نام کاربر وجود ندارد", @"هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            else
            {
                if (newPass != repPass)
                {
                    MessageBox.Show(@"در ورود گذرواژه دقت کنید", @"هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
                else
                {
                    var salt = Security.Salt;
                    var hashPass = salt + Security.SaltedHash(newPass, salt);
                    DAC.ExecuteSql("UPDATE Users SET Password='" + hashPass + "', brID='" +
                                         CmbBranches.SelectedValue + "', persID='" + CmbPeople.SelectedValue + "' WHERE userID='" +
                                         CmbUserName.Text + "'");
                    MessageBox.Show(@"مشخصات تغییر یافت.", @"پیام", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    txtPassEntry.Text = "";
                    txtPassRepeat.Text = "";
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var newPass = txtPassEntry.Text.Trim();
            var repPass = txtPassRepeat.Text.Trim();
            if ((DAC.IsNotFrequent("Users", "userID", CmbUserName.Text)) && (txtPassEntry.Text != "") && (newPass == repPass))
            {
                var salt = Security.Salt;
                var hashPass = salt + Security.SaltedHash(newPass, salt);
                var query =
                    "INSERT INTO USERS (userID, Password, brID, persID) VALUES ('" + CmbUserName.Text +
                    "','" + hashPass + "', '" + CmbBranches.SelectedValue + "', '" +
                    CmbPeople.SelectedValue + "')";
                DAC.MessageShow(DAC.ExecuteSql(query), @"نام کاربری افزوده شد",
                    "مشکل در ارتباط با پایگاه داده");
                BLL.LogIn.ComboFill(CmbUserName);
                
                txtPassEntry.Text = "";
                txtPassRepeat.Text = "";
            }
            else MessageBox.Show(@"گذرواژه خالی است یا نام کاربر پیش تر برگزیده شده است.", @"هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (DAC.IsNotFrequent("Users", "userID", CmbUserName.Text))
            {
                MessageBox.Show(@"نام کاربر وجود ندارد", @"هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            else
            {
                if (CmbUserName.Text == @"Administrator")
                {
                    MessageBox.Show(@"نمی توانید کاربر پیش فرض را حذف کنید", @"هشدار", MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
                else
                {
                    var dr=MessageBox.Show(@"آیا از حذف کاربر مطمئن هستید؟", @"حذف کاربر", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    if (dr != DialogResult.Yes) return;
                    DAC.ExecuteSql("DELETE FROM Users WHERE userID='" + CmbUserName.Text + "'");
                    MessageBox.Show(@"کاربر حذف شد", @"پیام", MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    BLL.LogIn.ComboFill(CmbUserName);
                }
            }
        }

        private void FrmUserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(CultureInfo.CreateSpecificCulture("fa-IR"));
            try
            {
                //Globals.SetUser(AppProperties.User.UserName);
            }
            catch
            {
                PersianMessageBox.Show(@"خطا در تأیید هویت کاربر.", @"هشدار");
                AppProperties.SenderObject = "AuthenticationError";
            }
        }

        private void CmbUserName_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void CmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
