namespace BaharNarenjERP
{
    partial class FrmUserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserManagement));
            this.CmbUserName = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassEntry = new System.Windows.Forms.TextBox();
            this.lblPassEntry = new System.Windows.Forms.Label();
            this.btnPassChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtPassRepeat = new System.Windows.Forms.TextBox();
            this.lblPassRepeat = new System.Windows.Forms.Label();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.LblPeople = new System.Windows.Forms.Label();
            this.CmbPeople = new System.Windows.Forms.ComboBox();
            this.CmbBranches = new System.Windows.Forms.ComboBox();
            this.LblBranch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbUserName
            // 
            this.CmbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbUserName.DropDownHeight = 250;
            this.CmbUserName.FormattingEnabled = true;
            this.CmbUserName.IntegralHeight = false;
            this.CmbUserName.Location = new System.Drawing.Point(87, 14);
            this.CmbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbUserName.Name = "CmbUserName";
            this.CmbUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbUserName.Size = new System.Drawing.Size(173, 28);
            this.CmbUserName.TabIndex = 0;
            this.CmbUserName.SelectedIndexChanged += new System.EventHandler(this.CmbUserName_SelectedIndexChanged);
            this.CmbUserName.Enter += new System.EventHandler(this.CmbUserName_Enter);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(22, 17);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 20);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "نام کاربری :";
            // 
            // txtPassEntry
            // 
            this.txtPassEntry.Location = new System.Drawing.Point(87, 52);
            this.txtPassEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassEntry.MaxLength = 25;
            this.txtPassEntry.Name = "txtPassEntry";
            this.txtPassEntry.PasswordChar = '*';
            this.txtPassEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassEntry.Size = new System.Drawing.Size(173, 27);
            this.txtPassEntry.TabIndex = 1;
            this.txtPassEntry.Enter += new System.EventHandler(this.CmbUserName_Enter);
            // 
            // lblPassEntry
            // 
            this.lblPassEntry.AutoSize = true;
            this.lblPassEntry.Location = new System.Drawing.Point(31, 55);
            this.lblPassEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassEntry.Name = "lblPassEntry";
            this.lblPassEntry.Size = new System.Drawing.Size(48, 20);
            this.lblPassEntry.TabIndex = 11;
            this.lblPassEntry.Text = "گذرواژه :";
            // 
            // btnPassChange
            // 
            this.btnPassChange.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPassChange.Location = new System.Drawing.Point(87, 202);
            this.btnPassChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPassChange.Name = "btnPassChange";
            this.btnPassChange.Size = new System.Drawing.Size(95, 32);
            this.btnPassChange.TabIndex = 5;
            this.btnPassChange.Text = "تغییر مشخصات";
            this.btnPassChange.UseVisualStyleBackColor = true;
            this.btnPassChange.Click += new System.EventHandler(this.btnPassChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(190, 244);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "بستن";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddUser.Location = new System.Drawing.Point(87, 244);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(95, 32);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "افزودن کاربر جدید";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtPassRepeat
            // 
            this.txtPassRepeat.Location = new System.Drawing.Point(87, 89);
            this.txtPassRepeat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassRepeat.MaxLength = 25;
            this.txtPassRepeat.Name = "txtPassRepeat";
            this.txtPassRepeat.PasswordChar = '*';
            this.txtPassRepeat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassRepeat.Size = new System.Drawing.Size(173, 27);
            this.txtPassRepeat.TabIndex = 2;
            this.txtPassRepeat.Enter += new System.EventHandler(this.CmbUserName_Enter);
            // 
            // lblPassRepeat
            // 
            this.lblPassRepeat.AutoSize = true;
            this.lblPassRepeat.Location = new System.Drawing.Point(8, 92);
            this.lblPassRepeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassRepeat.Name = "lblPassRepeat";
            this.lblPassRepeat.Size = new System.Drawing.Size(71, 20);
            this.lblPassRepeat.TabIndex = 12;
            this.lblPassRepeat.Text = "تکرار گذرواژه :";
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUserDelete.Location = new System.Drawing.Point(190, 202);
            this.btnUserDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(70, 32);
            this.btnUserDelete.TabIndex = 7;
            this.btnUserDelete.Text = "حذف کاربر";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // LblPeople
            // 
            this.LblPeople.AutoSize = true;
            this.LblPeople.Location = new System.Drawing.Point(25, 129);
            this.LblPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPeople.Name = "LblPeople";
            this.LblPeople.Size = new System.Drawing.Size(54, 20);
            this.LblPeople.TabIndex = 13;
            this.LblPeople.Text = "فرد مرتبط :";
            // 
            // CmbPeople
            // 
            this.CmbPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPeople.FormattingEnabled = true;
            this.CmbPeople.Location = new System.Drawing.Point(87, 126);
            this.CmbPeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbPeople.Name = "CmbPeople";
            this.CmbPeople.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbPeople.Size = new System.Drawing.Size(173, 28);
            this.CmbPeople.TabIndex = 3;
            // 
            // CmbBranches
            // 
            this.CmbBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBranches.FormattingEnabled = true;
            this.CmbBranches.Location = new System.Drawing.Point(87, 164);
            this.CmbBranches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbBranches.Name = "CmbBranches";
            this.CmbBranches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbBranches.Size = new System.Drawing.Size(173, 28);
            this.CmbBranches.TabIndex = 4;
            // 
            // LblBranch
            // 
            this.LblBranch.AutoSize = true;
            this.LblBranch.Location = new System.Drawing.Point(21, 167);
            this.LblBranch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBranch.Name = "LblBranch";
            this.LblBranch.Size = new System.Drawing.Size(58, 20);
            this.LblBranch.TabIndex = 15;
            this.LblBranch.Text = "شعبه مرتبط :";
            // 
            // FrmUserManagement
            // 
            this.AcceptButton = this.btnPassChange;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(274, 289);
            this.Controls.Add(this.CmbBranches);
            this.Controls.Add(this.LblBranch);
            this.Controls.Add(this.CmbPeople);
            this.Controls.Add(this.LblPeople);
            this.Controls.Add(this.btnUserDelete);
            this.Controls.Add(this.txtPassRepeat);
            this.Controls.Add(this.lblPassRepeat);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPassChange);
            this.Controls.Add(this.CmbUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPassEntry);
            this.Controls.Add(this.lblPassEntry);
            this.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmUserManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کاربرها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUserManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmPassChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassEntry;
        private System.Windows.Forms.Label lblPassEntry;
        private System.Windows.Forms.Button btnPassChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtPassRepeat;
        private System.Windows.Forms.Label lblPassRepeat;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Label LblPeople;
        private System.Windows.Forms.ComboBox CmbPeople;
        private System.Windows.Forms.ComboBox CmbBranches;
        private System.Windows.Forms.Label LblBranch;
    }
}