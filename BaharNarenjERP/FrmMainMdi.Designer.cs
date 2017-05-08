namespace BaharNarenjERP
{
    partial class FrmMainMdi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMdi));
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBasicInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPersonnel = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBranches = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuImages = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProforma = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNewCustProforma = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOldCustProforma = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCrm = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPotentialCust = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuServices = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProformaConfirm = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StsLblPrompt = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsLblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.TmrTime = new System.Windows.Forms.Timer(this.components);
            this.TmrTimeCheck = new System.Windows.Forms.Timer(this.components);
            this.PbxMain = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNewCustProforma = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.MnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMain
            // 
            this.MnuMain.Font = new System.Drawing.Font("B Yekan", 9F);
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.MnuSales,
            this.MnuCrm,
            this.MnuFinance,
            this.MnuTools,
            this.MnuGuide});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(784, 26);
            this.MnuMain.TabIndex = 0;
            this.MnuMain.Text = "MnuMain";
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuBasicInfo,
            this.MnuExit});
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(49, 22);
            this.MnuFile.Text = "پرونده";
            this.MnuFile.Click += new System.EventHandler(this.MnuFile_Click);
            // 
            // MnuBasicInfo
            // 
            this.MnuBasicInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPersonnel,
            this.MnuBranches,
            this.MnuImages});
            this.MnuBasicInfo.Name = "MnuBasicInfo";
            this.MnuBasicInfo.Size = new System.Drawing.Size(152, 22);
            this.MnuBasicInfo.Text = "اطلاعات پایه";
            // 
            // MnuPersonnel
            // 
            this.MnuPersonnel.Name = "MnuPersonnel";
            this.MnuPersonnel.Size = new System.Drawing.Size(176, 22);
            this.MnuPersonnel.Text = "پرسنل";
            this.MnuPersonnel.Click += new System.EventHandler(this.MnuPersonnel_Click);
            // 
            // MnuBranches
            // 
            this.MnuBranches.Name = "MnuBranches";
            this.MnuBranches.Size = new System.Drawing.Size(176, 22);
            this.MnuBranches.Text = "شعبه ها و نمایندگی ها";
            this.MnuBranches.Click += new System.EventHandler(this.MnuBranches_Click);
            // 
            // MnuImages
            // 
            this.MnuImages.Name = "MnuImages";
            this.MnuImages.Size = new System.Drawing.Size(176, 22);
            this.MnuImages.Text = "تصاویر";
            this.MnuImages.Click += new System.EventHandler(this.MnuImages_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(152, 22);
            this.MnuExit.Text = "خروج";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // MnuSales
            // 
            this.MnuSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuProforma});
            this.MnuSales.Name = "MnuSales";
            this.MnuSales.Size = new System.Drawing.Size(48, 22);
            this.MnuSales.Text = "فروش";
            // 
            // MnuProforma
            // 
            this.MnuProforma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuNewCustProforma,
            this.MnuOldCustProforma});
            this.MnuProforma.Name = "MnuProforma";
            this.MnuProforma.Size = new System.Drawing.Size(190, 22);
            this.MnuProforma.Text = "صدور پیش فاکتور مشتری";
            // 
            // MnuNewCustProforma
            // 
            this.MnuNewCustProforma.Name = "MnuNewCustProforma";
            this.MnuNewCustProforma.Size = new System.Drawing.Size(139, 22);
            this.MnuNewCustProforma.Text = "مشتری جدید";
            this.MnuNewCustProforma.Click += new System.EventHandler(this.MnuNewCustProforma_Click);
            // 
            // MnuOldCustProforma
            // 
            this.MnuOldCustProforma.Name = "MnuOldCustProforma";
            this.MnuOldCustProforma.Size = new System.Drawing.Size(139, 22);
            this.MnuOldCustProforma.Text = "مشتری قدیمی";
            this.MnuOldCustProforma.Click += new System.EventHandler(this.MnuOldCustProforma_Click);
            // 
            // MnuCrm
            // 
            this.MnuCrm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCustomers,
            this.MnuServices});
            this.MnuCrm.Name = "MnuCrm";
            this.MnuCrm.Size = new System.Drawing.Size(126, 22);
            this.MnuCrm.Text = "مدیریت ارتباط با مشتری";
            // 
            // MnuCustomers
            // 
            this.MnuCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPotentialCust});
            this.MnuCustomers.Name = "MnuCustomers";
            this.MnuCustomers.Size = new System.Drawing.Size(114, 22);
            this.MnuCustomers.Text = "مشتریان";
            // 
            // MnuPotentialCust
            // 
            this.MnuPotentialCust.Name = "MnuPotentialCust";
            this.MnuPotentialCust.Size = new System.Drawing.Size(141, 22);
            this.MnuPotentialCust.Text = "مشتریان بالقوه";
            this.MnuPotentialCust.Click += new System.EventHandler(this.MnuCustomers_Click);
            // 
            // MnuServices
            // 
            this.MnuServices.Name = "MnuServices";
            this.MnuServices.Size = new System.Drawing.Size(114, 22);
            this.MnuServices.Text = "خدمات";
            // 
            // MnuFinance
            // 
            this.MnuFinance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuProformaConfirm});
            this.MnuFinance.Name = "MnuFinance";
            this.MnuFinance.Size = new System.Drawing.Size(39, 22);
            this.MnuFinance.Text = "مالی";
            // 
            // MnuProformaConfirm
            // 
            this.MnuProformaConfirm.Name = "MnuProformaConfirm";
            this.MnuProformaConfirm.Size = new System.Drawing.Size(162, 22);
            this.MnuProformaConfirm.Text = "تأیید پیش فاکتورها";
            // 
            // MnuTools
            // 
            this.MnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuUserManagement,
            this.MnuOptions});
            this.MnuTools.Name = "MnuTools";
            this.MnuTools.Size = new System.Drawing.Size(39, 22);
            this.MnuTools.Text = "ابزار";
            // 
            // MnuUserManagement
            // 
            this.MnuUserManagement.Name = "MnuUserManagement";
            this.MnuUserManagement.Size = new System.Drawing.Size(146, 22);
            this.MnuUserManagement.Text = "مدیریت کاربران";
            this.MnuUserManagement.Click += new System.EventHandler(this.MnuUserManagement_Click);
            // 
            // MnuOptions
            // 
            this.MnuOptions.Name = "MnuOptions";
            this.MnuOptions.Size = new System.Drawing.Size(146, 22);
            this.MnuOptions.Text = "گزینه ها";
            this.MnuOptions.Click += new System.EventHandler(this.MnuOptions_Click);
            // 
            // MnuGuide
            // 
            this.MnuGuide.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MnuGuide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuHelp,
            this.MnuAbout});
            this.MnuGuide.Name = "MnuGuide";
            this.MnuGuide.Size = new System.Drawing.Size(47, 22);
            this.MnuGuide.Text = "راهنما";
            // 
            // MnuHelp
            // 
            this.MnuHelp.Name = "MnuHelp";
            this.MnuHelp.Size = new System.Drawing.Size(115, 22);
            this.MnuHelp.Text = "کمک";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(115, 22);
            this.MnuAbout.Text = "درباره ...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("B Yekan", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StsLblPrompt,
            this.StsLblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 23);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StsLblPrompt
            // 
            this.StsLblPrompt.BackColor = System.Drawing.Color.Transparent;
            this.StsLblPrompt.Name = "StsLblPrompt";
            this.StsLblPrompt.Size = new System.Drawing.Size(17, 18);
            this.StsLblPrompt.Text = "...";
            // 
            // StsLblDate
            // 
            this.StsLblDate.BackColor = System.Drawing.Color.Transparent;
            this.StsLblDate.Name = "StsLblDate";
            this.StsLblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StsLblDate.Size = new System.Drawing.Size(80, 18);
            this.StsLblDate.Text = "گروه صنعتی بهار";
            // 
            // TmrTime
            // 
            this.TmrTime.Enabled = true;
            this.TmrTime.Interval = 1000;
            this.TmrTime.Tick += new System.EventHandler(this.TmrTime_Tick);
            // 
            // TmrTimeCheck
            // 
            this.TmrTimeCheck.Enabled = true;
            this.TmrTimeCheck.Interval = 1;
            this.TmrTimeCheck.Tick += new System.EventHandler(this.TmrTimeCheck_Tick);
            // 
            // PbxMain
            // 
            this.PbxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxMain.Image = global::BaharNarenjERP.Properties.Resources.BaharERP001;
            this.PbxMain.Location = new System.Drawing.Point(0, 26);
            this.PbxMain.Name = "PbxMain";
            this.PbxMain.Size = new System.Drawing.Size(784, 512);
            this.PbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxMain.TabIndex = 4;
            this.PbxMain.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("B Yekan", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewCustProforma,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(69, 512);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnNewCustProforma
            // 
            this.BtnNewCustProforma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNewCustProforma.Image = global::BaharNarenjERP.Properties.Resources.Tasks1;
            this.BtnNewCustProforma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNewCustProforma.Name = "BtnNewCustProforma";
            this.BtnNewCustProforma.Size = new System.Drawing.Size(66, 68);
            this.BtnNewCustProforma.Text = "صدور پیش فاکتور مشتری جدید";
            this.BtnNewCustProforma.Click += new System.EventHandler(this.MnuNewCustProforma_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 68);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmMainMdi
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PbxMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MnuMain);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMainMdi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "برنامه ریزی منابع سازمانی - بهارنارنج";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMdi_FormClosing);
            this.Load += new System.EventHandler(this.FrmMainMdi_Load);
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MnuFile;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem MnuCrm;
        private System.Windows.Forms.ToolStripMenuItem MnuServices;
        private System.Windows.Forms.ToolStripMenuItem MnuCustomers;
        private System.Windows.Forms.ToolStripMenuItem MnuBasicInfo;
        private System.Windows.Forms.ToolStripMenuItem MnuPersonnel;
        private System.Windows.Forms.ToolStripMenuItem MnuBranches;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StsLblDate;
        private System.Windows.Forms.Timer TmrTime;
        private System.Windows.Forms.ToolStripMenuItem MnuPotentialCust;
        private System.Windows.Forms.ToolStripMenuItem MnuFinance;
        private System.Windows.Forms.ToolStripMenuItem MnuProformaConfirm;
        private System.Windows.Forms.PictureBox PbxMain;
        private System.Windows.Forms.ToolStripMenuItem MnuTools;
        private System.Windows.Forms.ToolStripMenuItem MnuOptions;
        private System.Windows.Forms.ToolStripMenuItem MnuGuide;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.ToolStripMenuItem MnuUserManagement;
        private System.Windows.Forms.Timer TmrTimeCheck;
        private System.Windows.Forms.ToolStripStatusLabel StsLblPrompt;
        private System.Windows.Forms.ToolStripMenuItem MnuSales;
        private System.Windows.Forms.ToolStripMenuItem MnuProforma;
        private System.Windows.Forms.ToolStripMenuItem MnuNewCustProforma;
        private System.Windows.Forms.ToolStripMenuItem MnuOldCustProforma;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNewCustProforma;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem MnuImages;
    }
}

