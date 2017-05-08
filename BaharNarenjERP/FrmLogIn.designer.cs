namespace BaharNarenjERP
{
    partial class FrmLogIn
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
            this.lblPassEntry = new System.Windows.Forms.Label();
            this.txtPassEntry = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPassEntry
            // 
            this.lblPassEntry.AutoSize = true;
            this.lblPassEntry.Location = new System.Drawing.Point(13, 62);
            this.lblPassEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassEntry.Name = "lblPassEntry";
            this.lblPassEntry.Size = new System.Drawing.Size(48, 20);
            this.lblPassEntry.TabIndex = 5;
            this.lblPassEntry.Text = "گذرواژه :";
            // 
            // txtPassEntry
            // 
            this.txtPassEntry.Location = new System.Drawing.Point(69, 59);
            this.txtPassEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassEntry.MaxLength = 25;
            this.txtPassEntry.Name = "txtPassEntry";
            this.txtPassEntry.PasswordChar = '*';
            this.txtPassEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassEntry.Size = new System.Drawing.Size(174, 27);
            this.txtPassEntry.TabIndex = 1;
            this.txtPassEntry.Enter += new System.EventHandler(this.cmbUserName_Enter);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(69, 96);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(174, 35);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "ورود";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("B Titr", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(69, 141);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "بستن برنامه";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(4, 20);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 20);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "نام کاربری :";
            // 
            // cmbUserName
            // 
            this.cmbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUserName.DropDownHeight = 160;
            this.cmbUserName.DropDownWidth = 170;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.IntegralHeight = false;
            this.cmbUserName.Location = new System.Drawing.Point(69, 17);
            this.cmbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbUserName.Size = new System.Drawing.Size(174, 28);
            this.cmbUserName.TabIndex = 0;
            this.cmbUserName.Enter += new System.EventHandler(this.cmbUserName_Enter);
            // 
            // FrmLogIn
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(260, 190);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPassEntry);
            this.Controls.Add(this.lblPassEntry);
            this.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(110, 90);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogIn";
            this.Opacity = 0.85D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گذرواژه";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogIn_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassEntry;
        private System.Windows.Forms.TextBox txtPassEntry;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox cmbUserName;
    }
}