namespace BaharNarenjERP
{
    partial class FrmPersonnel
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
            this.LblPersFname = new System.Windows.Forms.Label();
            this.TxtPersFname = new System.Windows.Forms.TextBox();
            this.TxtPersLname = new System.Windows.Forms.TextBox();
            this.LblPersLname = new System.Windows.Forms.Label();
            this.TxtPersId = new System.Windows.Forms.TextBox();
            this.LblPersID = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.DgvPersonnel = new System.Windows.Forms.DataGridView();
            this.LblPersonnel = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.StStripMain = new System.Windows.Forms.StatusStrip();
            this.StLblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonnel)).BeginInit();
            this.StStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblPersFname
            // 
            this.LblPersFname.AutoSize = true;
            this.LblPersFname.Location = new System.Drawing.Point(130, 9);
            this.LblPersFname.Name = "LblPersFname";
            this.LblPersFname.Size = new System.Drawing.Size(27, 18);
            this.LblPersFname.TabIndex = 0;
            this.LblPersFname.Text = "نام :";
            // 
            // TxtPersFname
            // 
            this.TxtPersFname.Location = new System.Drawing.Point(133, 30);
            this.TxtPersFname.Name = "TxtPersFname";
            this.TxtPersFname.Size = new System.Drawing.Size(132, 26);
            this.TxtPersFname.TabIndex = 1;
            // 
            // TxtPersLname
            // 
            this.TxtPersLname.Location = new System.Drawing.Point(271, 30);
            this.TxtPersLname.Name = "TxtPersLname";
            this.TxtPersLname.Size = new System.Drawing.Size(160, 26);
            this.TxtPersLname.TabIndex = 3;
            // 
            // LblPersLname
            // 
            this.LblPersLname.AutoSize = true;
            this.LblPersLname.Location = new System.Drawing.Point(268, 9);
            this.LblPersLname.Name = "LblPersLname";
            this.LblPersLname.Size = new System.Drawing.Size(69, 18);
            this.LblPersLname.TabIndex = 2;
            this.LblPersLname.Text = "نام خانوادگی :";
            // 
            // TxtPersId
            // 
            this.TxtPersId.Location = new System.Drawing.Point(12, 30);
            this.TxtPersId.Name = "TxtPersId";
            this.TxtPersId.Size = new System.Drawing.Size(115, 26);
            this.TxtPersId.TabIndex = 5;
            // 
            // LblPersID
            // 
            this.LblPersID.AutoSize = true;
            this.LblPersID.Location = new System.Drawing.Point(12, 9);
            this.LblPersID.Name = "LblPersID";
            this.LblPersID.Size = new System.Drawing.Size(78, 18);
            this.LblPersID.TabIndex = 4;
            this.LblPersID.Text = "شماره پرسنلی :";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(437, 30);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 26);
            this.BtnSubmit.TabIndex = 6;
            this.BtnSubmit.Text = "ثبت";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            // 
            // DgvPersonnel
            // 
            this.DgvPersonnel.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersonnel.Location = new System.Drawing.Point(12, 94);
            this.DgvPersonnel.Name = "DgvPersonnel";
            this.DgvPersonnel.Size = new System.Drawing.Size(500, 337);
            this.DgvPersonnel.TabIndex = 7;
            // 
            // LblPersonnel
            // 
            this.LblPersonnel.AutoSize = true;
            this.LblPersonnel.Location = new System.Drawing.Point(12, 73);
            this.LblPersonnel.Name = "LblPersonnel";
            this.LblPersonnel.Size = new System.Drawing.Size(81, 18);
            this.LblPersonnel.TabIndex = 8;
            this.LblPersonnel.Text = "فهرست پرسنل :";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(437, 62);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 26);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.Text = "جستجو";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // StStripMain
            // 
            this.StStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StLblInfo});
            this.StStripMain.Location = new System.Drawing.Point(0, 421);
            this.StStripMain.Name = "StStripMain";
            this.StStripMain.Size = new System.Drawing.Size(524, 22);
            this.StStripMain.TabIndex = 10;
            this.StStripMain.Text = "statusStrip1";
            // 
            // StLblInfo
            // 
            this.StLblInfo.Name = "StLblInfo";
            this.StLblInfo.Size = new System.Drawing.Size(16, 17);
            this.StLblInfo.Text = "...";
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 443);
            this.Controls.Add(this.StStripMain);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LblPersonnel);
            this.Controls.Add(this.DgvPersonnel);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtPersId);
            this.Controls.Add(this.LblPersID);
            this.Controls.Add(this.TxtPersLname);
            this.Controls.Add(this.LblPersLname);
            this.Controls.Add(this.TxtPersFname);
            this.Controls.Add(this.LblPersFname);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPersonnel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "کارکنان";
            this.Load += new System.EventHandler(this.FrmPersonnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonnel)).EndInit();
            this.StStripMain.ResumeLayout(false);
            this.StStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPersFname;
        private System.Windows.Forms.TextBox TxtPersFname;
        private System.Windows.Forms.TextBox TxtPersLname;
        private System.Windows.Forms.Label LblPersLname;
        private System.Windows.Forms.TextBox TxtPersId;
        private System.Windows.Forms.Label LblPersID;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.DataGridView DgvPersonnel;
        private System.Windows.Forms.Label LblPersonnel;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.StatusStrip StStripMain;
        private System.Windows.Forms.ToolStripStatusLabel StLblInfo;
    }
}