namespace BaharNarenjERP
{
    partial class FrmProductExtraInfo
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
            this.LblOptionDesc = new System.Windows.Forms.Label();
            this.LblProduct = new System.Windows.Forms.Label();
            this.LblOption = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LstOptions = new System.Windows.Forms.ListBox();
            this.LstOptionValues = new System.Windows.Forms.ListBox();
            this.TxtTxName = new System.Windows.Forms.TextBox();
            this.TxtTxCode = new System.Windows.Forms.TextBox();
            this.LblTxName = new System.Windows.Forms.Label();
            this.LblTxCode = new System.Windows.Forms.Label();
            this.DgvCurrentOptions = new System.Windows.Forms.DataGridView();
            this.LblSearchTextile = new System.Windows.Forms.Label();
            this.BtnAddOp = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StLblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblCurrentOptions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCurrentOptions)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblOptionDesc
            // 
            this.LblOptionDesc.AutoSize = true;
            this.LblOptionDesc.Location = new System.Drawing.Point(143, 79);
            this.LblOptionDesc.Name = "LblOptionDesc";
            this.LblOptionDesc.Size = new System.Drawing.Size(62, 18);
            this.LblOptionDesc.TabIndex = 110;
            this.LblOptionDesc.Text = "شرح آپشن :";
            // 
            // LblProduct
            // 
            this.LblProduct.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblProduct.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblProduct.Location = new System.Drawing.Point(426, 13);
            this.LblProduct.Name = "LblProduct";
            this.LblProduct.Size = new System.Drawing.Size(310, 26);
            this.LblProduct.TabIndex = 113;
            this.LblProduct.Text = "کالا....";
            this.LblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblOption
            // 
            this.LblOption.AutoSize = true;
            this.LblOption.Location = new System.Drawing.Point(12, 79);
            this.LblOption.Name = "LblOption";
            this.LblOption.Size = new System.Drawing.Size(39, 18);
            this.LblOption.TabIndex = 106;
            this.LblOption.Text = "آپشن :";
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("B Yekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnClose.Location = new System.Drawing.Point(641, 308);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(95, 29);
            this.BtnClose.TabIndex = 115;
            this.BtnClose.Text = "بستن";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // LstOptions
            // 
            this.LstOptions.FormattingEnabled = true;
            this.LstOptions.ItemHeight = 18;
            this.LstOptions.Location = new System.Drawing.Point(12, 100);
            this.LstOptions.Name = "LstOptions";
            this.LstOptions.Size = new System.Drawing.Size(128, 202);
            this.LstOptions.TabIndex = 116;
            // 
            // LstOptionValues
            // 
            this.LstOptionValues.FormattingEnabled = true;
            this.LstOptionValues.ItemHeight = 18;
            this.LstOptionValues.Location = new System.Drawing.Point(146, 100);
            this.LstOptionValues.Name = "LstOptionValues";
            this.LstOptionValues.Size = new System.Drawing.Size(218, 202);
            this.LstOptionValues.TabIndex = 116;
            // 
            // TxtTxName
            // 
            this.TxtTxName.Location = new System.Drawing.Point(150, 45);
            this.TxtTxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTxName.Name = "TxtTxName";
            this.TxtTxName.Size = new System.Drawing.Size(214, 26);
            this.TxtTxName.TabIndex = 117;
            this.TxtTxName.TextChanged += new System.EventHandler(this.TxtTxName_TextChanged);
            // 
            // TxtTxCode
            // 
            this.TxtTxCode.Location = new System.Drawing.Point(150, 13);
            this.TxtTxCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTxCode.Name = "TxtTxCode";
            this.TxtTxCode.Size = new System.Drawing.Size(128, 26);
            this.TxtTxCode.TabIndex = 118;
            this.TxtTxCode.TextChanged += new System.EventHandler(this.TxtTxCode_TextChanged);
            // 
            // LblTxName
            // 
            this.LblTxName.AutoSize = true;
            this.LblTxName.Location = new System.Drawing.Point(90, 48);
            this.LblTxName.Name = "LblTxName";
            this.LblTxName.Size = new System.Drawing.Size(54, 18);
            this.LblTxName.TabIndex = 119;
            this.LblTxName.Text = "نام پارچه :";
            // 
            // LblTxCode
            // 
            this.LblTxCode.AutoSize = true;
            this.LblTxCode.Location = new System.Drawing.Point(91, 16);
            this.LblTxCode.Name = "LblTxCode";
            this.LblTxCode.Size = new System.Drawing.Size(53, 18);
            this.LblTxCode.TabIndex = 120;
            this.LblTxCode.Text = "کد پارچه :";
            // 
            // DgvCurrentOptions
            // 
            this.DgvCurrentOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCurrentOptions.Location = new System.Drawing.Point(426, 100);
            this.DgvCurrentOptions.Name = "DgvCurrentOptions";
            this.DgvCurrentOptions.Size = new System.Drawing.Size(310, 202);
            this.DgvCurrentOptions.TabIndex = 121;
            // 
            // LblSearchTextile
            // 
            this.LblSearchTextile.AutoSize = true;
            this.LblSearchTextile.Location = new System.Drawing.Point(5, 34);
            this.LblSearchTextile.Name = "LblSearchTextile";
            this.LblSearchTextile.Size = new System.Drawing.Size(79, 18);
            this.LblSearchTextile.TabIndex = 120;
            this.LblSearchTextile.Text = "جستجوی پارچه :";
            // 
            // BtnAddOp
            // 
            this.BtnAddOp.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAddOp.Location = new System.Drawing.Point(370, 187);
            this.BtnAddOp.Name = "BtnAddOp";
            this.BtnAddOp.Size = new System.Drawing.Size(50, 29);
            this.BtnAddOp.TabIndex = 115;
            this.BtnAddOp.Text = ">";
            this.BtnAddOp.UseVisualStyleBackColor = true;
            this.BtnAddOp.Click += new System.EventHandler(this.BtnAddOp_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StLblInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 122;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StLblInfo
            // 
            this.StLblInfo.Name = "StLblInfo";
            this.StLblInfo.Size = new System.Drawing.Size(16, 17);
            this.StLblInfo.Text = "...";
            // 
            // LblCurrentOptions
            // 
            this.LblCurrentOptions.AutoSize = true;
            this.LblCurrentOptions.Location = new System.Drawing.Point(423, 79);
            this.LblCurrentOptions.Name = "LblCurrentOptions";
            this.LblCurrentOptions.Size = new System.Drawing.Size(115, 18);
            this.LblCurrentOptions.TabIndex = 110;
            this.LblCurrentOptions.Text = "آپشن های انتخاب شده :";
            // 
            // FrmProductExtraInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 363);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DgvCurrentOptions);
            this.Controls.Add(this.TxtTxName);
            this.Controls.Add(this.TxtTxCode);
            this.Controls.Add(this.LblTxName);
            this.Controls.Add(this.LblSearchTextile);
            this.Controls.Add(this.LblTxCode);
            this.Controls.Add(this.LstOptionValues);
            this.Controls.Add(this.LstOptions);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAddOp);
            this.Controls.Add(this.LblCurrentOptions);
            this.Controls.Add(this.LblOptionDesc);
            this.Controls.Add(this.LblProduct);
            this.Controls.Add(this.LblOption);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductExtraInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "جزئیات پارچه و آپشن ها";
            this.Load += new System.EventHandler(this.FrmProductExtraInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCurrentOptions)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblOptionDesc;
        private System.Windows.Forms.Label LblProduct;
        private System.Windows.Forms.Label LblOption;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ListBox LstOptions;
        private System.Windows.Forms.ListBox LstOptionValues;
        private System.Windows.Forms.TextBox TxtTxName;
        private System.Windows.Forms.TextBox TxtTxCode;
        private System.Windows.Forms.Label LblTxName;
        private System.Windows.Forms.Label LblTxCode;
        private System.Windows.Forms.DataGridView DgvCurrentOptions;
        private System.Windows.Forms.Label LblSearchTextile;
        private System.Windows.Forms.Button BtnAddOp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StLblInfo;
        private System.Windows.Forms.Label LblCurrentOptions;
    }
}