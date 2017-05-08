namespace BaharNarenjERP
{
    partial class FrmBranches
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBranchCode = new System.Windows.Forms.TextBox();
            this.CmbBranchType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBranchName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbCities = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.DgvBranches = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.StStripMain = new System.Windows.Forms.StatusStrip();
            this.StLblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ImlBranchLogos = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBranches)).BeginInit();
            this.StStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد نمایندگی :";
            // 
            // TxtBranchCode
            // 
            this.TxtBranchCode.Location = new System.Drawing.Point(12, 32);
            this.TxtBranchCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBranchCode.Name = "TxtBranchCode";
            this.TxtBranchCode.Size = new System.Drawing.Size(100, 26);
            this.TxtBranchCode.TabIndex = 0;
            // 
            // CmbBranchType
            // 
            this.CmbBranchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBranchType.FormattingEnabled = true;
            this.CmbBranchType.Location = new System.Drawing.Point(470, 32);
            this.CmbBranchType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbBranchType.Name = "CmbBranchType";
            this.CmbBranchType.Size = new System.Drawing.Size(144, 26);
            this.CmbBranchType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "نوع نمایندگی :";
            // 
            // TxtBranchName
            // 
            this.TxtBranchName.Location = new System.Drawing.Point(118, 32);
            this.TxtBranchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBranchName.Name = "TxtBranchName";
            this.TxtBranchName.Size = new System.Drawing.Size(187, 26);
            this.TxtBranchName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام نمایندگی :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "شهر :";
            // 
            // CmbCities
            // 
            this.CmbCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCities.FormattingEnabled = true;
            this.CmbCities.Location = new System.Drawing.Point(311, 32);
            this.CmbCities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbCities.Name = "CmbCities";
            this.CmbCities.Size = new System.Drawing.Size(153, 26);
            this.CmbCities.TabIndex = 2;
            // 
            // BtnDelete
            // 
            this.BtnDelete.ForeColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(378, 79);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(86, 28);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "حذف نمایندگی";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(470, 79);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(144, 28);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "ثبت (ویرایش) نمایندگی";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // DgvBranches
            // 
            this.DgvBranches.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DgvBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBranches.Location = new System.Drawing.Point(12, 133);
            this.DgvBranches.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvBranches.Name = "DgvBranches";
            this.DgvBranches.Size = new System.Drawing.Size(602, 394);
            this.DgvBranches.TabIndex = 6;
            this.DgvBranches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBranches_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "نمایندگی ها :";
            // 
            // StStripMain
            // 
            this.StStripMain.Font = new System.Drawing.Font("B Yekan", 9F);
            this.StStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StLblInfo});
            this.StStripMain.Location = new System.Drawing.Point(0, 518);
            this.StStripMain.Name = "StStripMain";
            this.StStripMain.Size = new System.Drawing.Size(626, 23);
            this.StStripMain.TabIndex = 36;
            this.StStripMain.Text = "statusStrip1";
            // 
            // StLblInfo
            // 
            this.StLblInfo.Name = "StLblInfo";
            this.StLblInfo.Size = new System.Drawing.Size(17, 18);
            this.StLblInfo.Text = "...";
            // 
            // ImlBranchLogos
            // 
            this.ImlBranchLogos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImlBranchLogos.ImageSize = new System.Drawing.Size(16, 16);
            this.ImlBranchLogos.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 541);
            this.Controls.Add(this.StStripMain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgvBranches);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.CmbCities);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBranchName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbBranchType);
            this.Controls.Add(this.TxtBranchCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmBranches";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شعبه ها و نمایندگی ها";
            this.Load += new System.EventHandler(this.FrmBranches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBranches)).EndInit();
            this.StStripMain.ResumeLayout(false);
            this.StStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBranchCode;
        private System.Windows.Forms.ComboBox CmbBranchType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBranchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbCities;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.DataGridView DgvBranches;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip StStripMain;
        private System.Windows.Forms.ToolStripStatusLabel StLblInfo;
        private System.Windows.Forms.ImageList ImlBranchLogos;
    }
}