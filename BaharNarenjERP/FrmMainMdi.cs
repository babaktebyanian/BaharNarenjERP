using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using Persia;

namespace BaharNarenjERP
{
    public partial class FrmMainMdi : Form
    {
        private InputLanguage _il;
        private readonly TimeSpan _oneSecond = new TimeSpan(0, 0, 1);
        private SolarDate _now;
        public FrmMainMdi()
        {
            InitializeComponent();
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuCustomers_Click(object sender, EventArgs e)
        {
            var frm = SingletonProvider<FrmCustomers>.Instance;
            frm.MdiParent = this;
            frm.Icon = Icon;
            frm.Parent = PbxMain;
            frm.Show();
        }

        private void MnuBranches_Click(object sender, EventArgs e)
        {
            var frm = SingletonProvider<FrmBranches>.Instance;
            frm.MdiParent = this;
            frm.Icon = Icon;
            frm.Parent = PbxMain;
            frm.Show();
        }

        private void FrmMainMdi_Load(object sender, EventArgs e)
        {
            //TmrTime.Enabled = false;
            _il = InputLanguage.CurrentInputLanguage;
            Text =
                ((AssemblyProductAttribute)
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false)[0])
                    .Product + @" ";
            Text += Assembly.GetExecutingAssembly().GetName().Version.Major + @"." +
                    Assembly.GetExecutingAssembly().GetName().Version.Minor + @"." +
                    Assembly.GetExecutingAssembly().GetName().Version.Build + @"." +
                    Assembly.GetExecutingAssembly().GetName().Version.Revision;
            Text += @" on " + Environment.MachineName;
            InputLanguage.CurrentInputLanguage =
                InputLanguage.FromCulture(CultureInfo.CreateSpecificCulture("fa-IR"));
            //if (DAC.RowCount("users") == 0) return;
            Enabled = false;
            (new FrmLogIn { Icon = Icon }).ShowDialog();
            Enabled = true;
            Text += @" - " + AppProperties.User.persFName + @" " + AppProperties.User.persLName;
            InputLanguage.CurrentInputLanguage =
                InputLanguage.FromCulture(CultureInfo.CreateSpecificCulture("fa-IR"));
            if (AppProperties.User.brID == "9999" || AppProperties.MasterEntrance) return;
            MnuTools.Visible = false;
            //MnuUserManagement.Visible = false;
            //MnuOptions.Visible = false;
        }

        private void TmrTime_Tick(object sender, EventArgs e)
        {
            if (_now == null) return;
            _now = Persia.Calendar.ConvertToPersian(Persia.Calendar.ConvertToGregorian(_now) + _oneSecond);
            StsLblDate.Text = _now.ToString("S,H");
        }

        private void MnuNewCustProforma_Click(object sender, EventArgs e)
        {
            var frm = SingletonProvider<FrmInvoice>.Instance;
            frm.MdiParent = this;
            frm.Icon = Icon;
            frm.Parent = PbxMain;
            frm.Show();
        }

        private void FrmMainMdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            InputLanguage.CurrentInputLanguage = _il;
            if (AppProperties.ForceClose) return;
            var dr = MessageBox.Show(@"آیا از خروج مطمئن هستید؟", @"خروج", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            if (dr == DialogResult.Yes) return;
            e.Cancel = true;
            Activate();
            InputLanguage.CurrentInputLanguage =
                InputLanguage.FromCulture(CultureInfo.CreateSpecificCulture("fa-IR"));
        }

        private void MnuPersonnel_Click(object sender, EventArgs e)
        {
            var frm = SingletonProvider<FrmPersonnel>.Instance;
            frm.MdiParent = this;
            frm.Icon = Icon;
            frm.Parent = PbxMain;
            frm.Show();
        }

        private void MnuUserManagement_Click(object sender, EventArgs e)
        {
            (new FrmUserManagement() {Icon = Icon}).ShowDialog(this);
        }

        private void TmrTimeCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                var t = new NtpTime(Properties.Settings.Default.TimeServer,
                    Properties.Settings.Default.TimeZoneHour * 60 + Properties.Settings.Default.TimeZoneMinute);
                _now = Persia.Calendar.ConvertToPersian(t.Now);
                StsLblPrompt.Text = $"زمان اینترنتی : ";
                TmrTimeCheck.Interval = 3600000;
            }
            catch
            {
                //StsLblDate.Text = @"ارتباط با اینترنت مقدور نیست.";
                _now = Persia.Calendar.ConvertToPersian(DateTime.Now);
                StsLblPrompt.Text = $"زمان محلی : ";
                TmrTimeCheck.Interval = 3600000;
            }
        }

        private void MnuOptions_Click(object sender, EventArgs e)
        {
            (new FrmSettings() { Icon = Icon }).ShowDialog(this);
        }

        private void MnuOldCustProforma_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //AppProperties.ModalAccess = false;
            //var frm = SingletonProvider<FrmImages>.Instance;
            //frm.MdiParent = this;
            //frm.Icon = Icon;
            //frm.Parent = PbxMain;
            //frm.Show();
        }

        private void MnuImages_Click(object sender, EventArgs e)
        {
            AppProperties.ModalAccess = false;
            var frm = SingletonProvider<FrmImages>.Instance;
            frm.MdiParent = this;
            frm.Icon = Icon;
            frm.Parent = PbxMain;
            frm.Show();
        }

        private void MnuFile_Click(object sender, EventArgs e)
        {

        }
    }
}
