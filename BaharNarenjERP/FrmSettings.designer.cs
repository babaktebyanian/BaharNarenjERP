namespace BaharNarenjERP
{
    partial class FrmSettings
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
            this.TbcSettings = new System.Windows.Forms.TabControl();
            this.TpGeneral = new System.Windows.Forms.TabPage();
            this.LblEndNote = new System.Windows.Forms.Label();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.TpDatabase = new System.Windows.Forms.TabPage();
            this.LblInfo = new System.Windows.Forms.Label();
            this.BtnConTest = new System.Windows.Forms.Button();
            this.LblDatabase = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUserId = new System.Windows.Forms.Label();
            this.LblPort = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.LblServer = new System.Windows.Forms.Label();
            this.TpTime = new System.Windows.Forms.TabPage();
            this.LblTimeServer = new System.Windows.Forms.Label();
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtDeliveryDifference = new System.Windows.Forms.TextBox();
            this.LblDeliveryDifference = new System.Windows.Forms.Label();
            this.TxtEndNote = new System.Windows.Forms.TextBox();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtDatebase = new System.Windows.Forms.TextBox();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.TxtServer = new System.Windows.Forms.TextBox();
            this.TxtTimeServer = new System.Windows.Forms.TextBox();
            this.TbcSettings.SuspendLayout();
            this.TpGeneral.SuspendLayout();
            this.TpDatabase.SuspendLayout();
            this.TpTime.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbcSettings
            // 
            this.TbcSettings.Controls.Add(this.TpGeneral);
            this.TbcSettings.Controls.Add(this.TpDatabase);
            this.TbcSettings.Controls.Add(this.TpTime);
            this.TbcSettings.Controls.Add(this.tabPage1);
            this.TbcSettings.Location = new System.Drawing.Point(12, 12);
            this.TbcSettings.Name = "TbcSettings";
            this.TbcSettings.RightToLeftLayout = true;
            this.TbcSettings.SelectedIndex = 0;
            this.TbcSettings.Size = new System.Drawing.Size(410, 231);
            this.TbcSettings.TabIndex = 0;
            // 
            // TpGeneral
            // 
            this.TpGeneral.Controls.Add(this.TxtEndNote);
            this.TpGeneral.Controls.Add(this.LblEndNote);
            this.TpGeneral.Controls.Add(this.TxtCompanyName);
            this.TpGeneral.Controls.Add(this.LblCompanyName);
            this.TpGeneral.Location = new System.Drawing.Point(4, 27);
            this.TpGeneral.Name = "TpGeneral";
            this.TpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.TpGeneral.Size = new System.Drawing.Size(402, 200);
            this.TpGeneral.TabIndex = 0;
            this.TpGeneral.Text = "عمومی";
            this.TpGeneral.UseVisualStyleBackColor = true;
            // 
            // LblEndNote
            // 
            this.LblEndNote.AutoSize = true;
            this.LblEndNote.Location = new System.Drawing.Point(242, 77);
            this.LblEndNote.Name = "LblEndNote";
            this.LblEndNote.Size = new System.Drawing.Size(117, 18);
            this.LblEndNote.TabIndex = 2;
            this.LblEndNote.Text = "توضیحات انتهای گزارش :";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(242, 35);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(59, 18);
            this.LblCompanyName.TabIndex = 0;
            this.LblCompanyName.Text = "نام شرکت :";
            // 
            // TpDatabase
            // 
            this.TpDatabase.Controls.Add(this.LblInfo);
            this.TpDatabase.Controls.Add(this.BtnConTest);
            this.TpDatabase.Controls.Add(this.LblDatabase);
            this.TpDatabase.Controls.Add(this.LblPassword);
            this.TpDatabase.Controls.Add(this.TxtPassword);
            this.TpDatabase.Controls.Add(this.LblUserId);
            this.TpDatabase.Controls.Add(this.LblPort);
            this.TpDatabase.Controls.Add(this.TxtPort);
            this.TpDatabase.Controls.Add(this.LblServer);
            this.TpDatabase.Controls.Add(this.TxtDatebase);
            this.TpDatabase.Controls.Add(this.TxtUserId);
            this.TpDatabase.Controls.Add(this.TxtServer);
            this.TpDatabase.Location = new System.Drawing.Point(4, 27);
            this.TpDatabase.Name = "TpDatabase";
            this.TpDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.TpDatabase.Size = new System.Drawing.Size(402, 200);
            this.TpDatabase.TabIndex = 1;
            this.TpDatabase.Text = "پایگاه داده";
            this.TpDatabase.UseVisualStyleBackColor = true;
            // 
            // LblInfo
            // 
            this.LblInfo.ForeColor = System.Drawing.Color.Red;
            this.LblInfo.Location = new System.Drawing.Point(6, 29);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(141, 117);
            this.LblInfo.TabIndex = 11;
            this.LblInfo.Text = "برای اعمال تنظیمات اتصال با پایگاه داده، برنامه را دوباره راه اندازی کنید.";
            this.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnConTest
            // 
            this.BtnConTest.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnConTest.Location = new System.Drawing.Point(6, 157);
            this.BtnConTest.Name = "BtnConTest";
            this.BtnConTest.Size = new System.Drawing.Size(141, 26);
            this.BtnConTest.TabIndex = 10;
            this.BtnConTest.Text = "تست اتصال";
            this.BtnConTest.UseVisualStyleBackColor = true;
            this.BtnConTest.Click += new System.EventHandler(this.BtnConTest_Click);
            // 
            // LblDatabase
            // 
            this.LblDatabase.AutoSize = true;
            this.LblDatabase.Location = new System.Drawing.Point(329, 160);
            this.LblDatabase.Name = "LblDatabase";
            this.LblDatabase.Size = new System.Drawing.Size(67, 18);
            this.LblDatabase.TabIndex = 9;
            this.LblDatabase.Text = "نام دیتابیس :";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(329, 128);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(49, 18);
            this.LblPassword.TabIndex = 7;
            this.LblPassword.Text = "گذرواژه :";
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Location = new System.Drawing.Point(329, 93);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(59, 18);
            this.LblUserId.TabIndex = 5;
            this.LblUserId.Text = "نام کاربری :";
            // 
            // LblPort
            // 
            this.LblPort.AutoSize = true;
            this.LblPort.Location = new System.Drawing.Point(329, 61);
            this.LblPort.Name = "LblPort";
            this.LblPort.Size = new System.Drawing.Size(38, 18);
            this.LblPort.TabIndex = 3;
            this.LblPort.Text = "درگاه :";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(153, 58);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPort.Size = new System.Drawing.Size(170, 26);
            this.TxtPort.TabIndex = 2;
            // 
            // LblServer
            // 
            this.LblServer.AutoSize = true;
            this.LblServer.Location = new System.Drawing.Point(329, 29);
            this.LblServer.Name = "LblServer";
            this.LblServer.Size = new System.Drawing.Size(38, 18);
            this.LblServer.TabIndex = 1;
            this.LblServer.Text = "سرور :";
            // 
            // TpTime
            // 
            this.TpTime.Controls.Add(this.LblTimeServer);
            this.TpTime.Controls.Add(this.TxtTimeServer);
            this.TpTime.Location = new System.Drawing.Point(4, 27);
            this.TpTime.Name = "TpTime";
            this.TpTime.Padding = new System.Windows.Forms.Padding(3);
            this.TpTime.Size = new System.Drawing.Size(402, 200);
            this.TpTime.TabIndex = 2;
            this.TpTime.Text = "زمان";
            this.TpTime.UseVisualStyleBackColor = true;
            // 
            // LblTimeServer
            // 
            this.LblTimeServer.AutoSize = true;
            this.LblTimeServer.Location = new System.Drawing.Point(317, 33);
            this.LblTimeServer.Name = "LblTimeServer";
            this.LblTimeServer.Size = new System.Drawing.Size(62, 18);
            this.LblTimeServer.TabIndex = 5;
            this.LblTimeServer.Text = "سرور زمان :";
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(185, 249);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(75, 23);
            this.BtnApply.TabIndex = 11;
            this.BtnApply.Text = "اعمال";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(347, 249);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 12;
            this.BtnOk.Text = "تأیید";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(266, 249);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "لغو";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LblDeliveryDifference);
            this.tabPage1.Controls.Add(this.TxtDeliveryDifference);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 200);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "فاکتور";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtDeliveryDifference
            // 
            this.TxtDeliveryDifference.Location = new System.Drawing.Point(10, 6);
            this.TxtDeliveryDifference.Name = "TxtDeliveryDifference";
            this.TxtDeliveryDifference.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtDeliveryDifference.Size = new System.Drawing.Size(76, 26);
            this.TxtDeliveryDifference.TabIndex = 0;
            // 
            // LblDeliveryDifference
            // 
            this.LblDeliveryDifference.AutoSize = true;
            this.LblDeliveryDifference.Location = new System.Drawing.Point(206, 9);
            this.LblDeliveryDifference.Name = "LblDeliveryDifference";
            this.LblDeliveryDifference.Size = new System.Drawing.Size(190, 18);
            this.LblDeliveryDifference.TabIndex = 1;
            this.LblDeliveryDifference.Text = "حداقل فاصله بین سفارش و تحویل (روز):";
            // 
            // TxtEndNote
            // 
            this.TxtEndNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BaharNarenjERP.Properties.Settings.Default, "EndNote", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtEndNote.Location = new System.Drawing.Point(6, 74);
            this.TxtEndNote.Multiline = true;
            this.TxtEndNote.Name = "TxtEndNote";
            this.TxtEndNote.Size = new System.Drawing.Size(230, 104);
            this.TxtEndNote.TabIndex = 3;
            this.TxtEndNote.Text = global::BaharNarenjERP.Properties.Settings.Default.EndNote;
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BaharNarenjERP.Properties.Settings.Default, "CompanyName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtCompanyName.Location = new System.Drawing.Point(6, 32);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(230, 26);
            this.TxtCompanyName.TabIndex = 1;
            this.TxtCompanyName.Text = global::BaharNarenjERP.Properties.Settings.Default.CompanyName;
            // 
            // TxtPassword
            // 
            this.TxtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BaharNarenjERP.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtPassword.Location = new System.Drawing.Point(153, 125);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPassword.Size = new System.Drawing.Size(170, 26);
            this.TxtPassword.TabIndex = 6;
            this.TxtPassword.Text = global::BaharNarenjERP.Properties.Settings.Default.Password;
            // 
            // TxtDatebase
            // 
            this.TxtDatebase.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BaharNarenjERP.Properties.Settings.Default, "DataBase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtDatebase.Location = new System.Drawing.Point(153, 157);
            this.TxtDatebase.Name = "TxtDatebase";
            this.TxtDatebase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtDatebase.Size = new System.Drawing.Size(170, 26);
            this.TxtDatebase.TabIndex = 8;
            this.TxtDatebase.Text = global::BaharNarenjERP.Properties.Settings.Default.DataBase;
            // 
            // TxtUserId
            // 
            this.TxtUserId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BaharNarenjERP.Properties.Settings.Default, "UserID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtUserId.Location = new System.Drawing.Point(153, 90);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtUserId.Size = new System.Drawing.Size(170, 26);
            this.TxtUserId.TabIndex = 4;
            this.TxtUserId.Text = global::BaharNarenjERP.Properties.Settings.Default.UserID;
            // 
            // TxtServer
            // 
            this.TxtServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BaharNarenjERP.Properties.Settings.Default, "Server", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtServer.Location = new System.Drawing.Point(153, 26);
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtServer.Size = new System.Drawing.Size(170, 26);
            this.TxtServer.TabIndex = 0;
            this.TxtServer.Text = global::BaharNarenjERP.Properties.Settings.Default.Server;
            // 
            // TxtTimeServer
            // 
            this.TxtTimeServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BaharNarenjERP.Properties.Settings.Default, "TimeServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtTimeServer.Location = new System.Drawing.Point(141, 30);
            this.TxtTimeServer.Name = "TxtTimeServer";
            this.TxtTimeServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtTimeServer.Size = new System.Drawing.Size(170, 26);
            this.TxtTimeServer.TabIndex = 4;
            this.TxtTimeServer.Text = global::BaharNarenjERP.Properties.Settings.Default.TimeServer;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(434, 281);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.TbcSettings);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "پیکربندی";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.TbcSettings.ResumeLayout(false);
            this.TpGeneral.ResumeLayout(false);
            this.TpGeneral.PerformLayout();
            this.TpDatabase.ResumeLayout(false);
            this.TpDatabase.PerformLayout();
            this.TpTime.ResumeLayout(false);
            this.TpTime.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcSettings;
        private System.Windows.Forms.TabPage TpGeneral;
        private System.Windows.Forms.TabPage TpDatabase;
        private System.Windows.Forms.Label LblDatabase;
        private System.Windows.Forms.TextBox TxtDatebase;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblUserId;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label LblPort;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Label LblServer;
        private System.Windows.Forms.TextBox TxtServer;
        private System.Windows.Forms.Button BtnConTest;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtEndNote;
        private System.Windows.Forms.Label LblEndNote;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.TabPage TpTime;
        private System.Windows.Forms.Label LblTimeServer;
        private System.Windows.Forms.TextBox TxtTimeServer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LblDeliveryDifference;
        private System.Windows.Forms.TextBox TxtDeliveryDifference;
    }
}