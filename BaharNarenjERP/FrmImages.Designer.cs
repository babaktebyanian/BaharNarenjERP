namespace BaharNarenjERP
{
    partial class FrmImages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImages));
            this.BtnClose = new System.Windows.Forms.Button();
            this.DgvImages = new System.Windows.Forms.DataGridView();
            this.TxtImageAddress = new System.Windows.Forms.TextBox();
            this.PbxImage = new System.Windows.Forms.PictureBox();
            this.LblImageAddress = new System.Windows.Forms.Label();
            this.OfdImage = new System.Windows.Forms.OpenFileDialog();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.TxtImageDesc = new System.Windows.Forms.TextBox();
            this.LblImageDesc = new System.Windows.Forms.Label();
            this.StrStatus = new System.Windows.Forms.StatusStrip();
            this.StsLblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage)).BeginInit();
            this.StrStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(451, 398);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "بستن";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DgvImages
            // 
            this.DgvImages.AllowUserToAddRows = false;
            this.DgvImages.AllowUserToDeleteRows = false;
            this.DgvImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvImages.Location = new System.Drawing.Point(12, 118);
            this.DgvImages.Name = "DgvImages";
            this.DgvImages.ReadOnly = true;
            this.DgvImages.RowTemplate.Height = 50;
            this.DgvImages.Size = new System.Drawing.Size(514, 274);
            this.DgvImages.TabIndex = 5;
            this.DgvImages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvImages_CellClick);
            this.DgvImages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvImages_CellDoubleClick);
            // 
            // TxtImageAddress
            // 
            this.TxtImageAddress.Enabled = false;
            this.TxtImageAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtImageAddress.Location = new System.Drawing.Point(93, 12);
            this.TxtImageAddress.Name = "TxtImageAddress";
            this.TxtImageAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtImageAddress.Size = new System.Drawing.Size(277, 23);
            this.TxtImageAddress.TabIndex = 0;
            // 
            // PbxImage
            // 
            this.PbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxImage.Location = new System.Drawing.Point(376, 12);
            this.PbxImage.Name = "PbxImage";
            this.PbxImage.Size = new System.Drawing.Size(150, 100);
            this.PbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxImage.TabIndex = 3;
            this.PbxImage.TabStop = false;
            this.PbxImage.Click += new System.EventHandler(this.PbxImage_Click);
            this.PbxImage.MouseEnter += new System.EventHandler(this.PbxImage_MouseEnter);
            this.PbxImage.MouseLeave += new System.EventHandler(this.PbxImage_MouseLeave);
            // 
            // LblImageAddress
            // 
            this.LblImageAddress.AutoSize = true;
            this.LblImageAddress.Location = new System.Drawing.Point(15, 15);
            this.LblImageAddress.Name = "LblImageAddress";
            this.LblImageAddress.Size = new System.Drawing.Size(72, 18);
            this.LblImageAddress.TabIndex = 4;
            this.LblImageAddress.Text = "آدرس تصویر :";
            // 
            // OfdImage
            // 
            this.OfdImage.Filter = "تصاویر (*.jpg, *.png)|*.jpg;*.png";
            this.OfdImage.Title = "انتخاب تصویر";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnInsert.Location = new System.Drawing.Point(291, 73);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(79, 39);
            this.BtnInsert.TabIndex = 2;
            this.BtnInsert.Text = "ثبت";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // TxtImageDesc
            // 
            this.TxtImageDesc.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtImageDesc.Location = new System.Drawing.Point(93, 41);
            this.TxtImageDesc.Name = "TxtImageDesc";
            this.TxtImageDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtImageDesc.Size = new System.Drawing.Size(277, 26);
            this.TxtImageDesc.TabIndex = 1;
            // 
            // LblImageDesc
            // 
            this.LblImageDesc.AutoSize = true;
            this.LblImageDesc.Location = new System.Drawing.Point(15, 44);
            this.LblImageDesc.Name = "LblImageDesc";
            this.LblImageDesc.Size = new System.Drawing.Size(64, 18);
            this.LblImageDesc.TabIndex = 4;
            this.LblImageDesc.Text = "شرح تصویر :";
            // 
            // StrStatus
            // 
            this.StrStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StsLblInfo});
            this.StrStatus.Location = new System.Drawing.Point(0, 427);
            this.StrStatus.Name = "StrStatus";
            this.StrStatus.Size = new System.Drawing.Size(538, 23);
            this.StrStatus.TabIndex = 6;
            this.StrStatus.Text = "نوار وضعیت";
            // 
            // StsLblInfo
            // 
            this.StsLblInfo.Font = new System.Drawing.Font("B Yekan", 9F);
            this.StsLblInfo.Name = "StsLblInfo";
            this.StsLblInfo.Size = new System.Drawing.Size(17, 18);
            this.StsLblInfo.Text = "...";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(93, 73);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(49, 39);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.StrStatus);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.LblImageDesc);
            this.Controls.Add(this.LblImageAddress);
            this.Controls.Add(this.PbxImage);
            this.Controls.Add(this.TxtImageDesc);
            this.Controls.Add(this.TxtImageAddress);
            this.Controls.Add(this.DgvImages);
            this.Controls.Add(this.BtnClose);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmImages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "سیاهه ی تصاویر";
            this.Load += new System.EventHandler(this.FrmImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage)).EndInit();
            this.StrStatus.ResumeLayout(false);
            this.StrStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView DgvImages;
        private System.Windows.Forms.TextBox TxtImageAddress;
        private System.Windows.Forms.PictureBox PbxImage;
        private System.Windows.Forms.Label LblImageAddress;
        private System.Windows.Forms.OpenFileDialog OfdImage;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox TxtImageDesc;
        private System.Windows.Forms.Label LblImageDesc;
        private System.Windows.Forms.StatusStrip StrStatus;
        private System.Windows.Forms.ToolStripStatusLabel StsLblInfo;
        private System.Windows.Forms.Button BtnDelete;
    }
}