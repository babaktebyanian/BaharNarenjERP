namespace BaharNarenjERP
{
    partial class FrmProductSearch
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
            this.TxtPrCode = new System.Windows.Forms.TextBox();
            this.LblPrName = new System.Windows.Forms.Label();
            this.LblPrCode = new System.Windows.Forms.Label();
            this.TxtPrName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StLblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPrCode
            // 
            this.TxtPrCode.Location = new System.Drawing.Point(12, 31);
            this.TxtPrCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPrCode.Name = "TxtPrCode";
            this.TxtPrCode.Size = new System.Drawing.Size(128, 26);
            this.TxtPrCode.TabIndex = 104;
            this.TxtPrCode.TextChanged += new System.EventHandler(this.TxtPrCode_TextChanged);
            this.TxtPrCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProductSearch_KeyDown);
            // 
            // LblPrName
            // 
            this.LblPrName.AutoSize = true;
            this.LblPrName.Location = new System.Drawing.Point(143, 9);
            this.LblPrName.Name = "LblPrName";
            this.LblPrName.Size = new System.Drawing.Size(44, 18);
            this.LblPrName.TabIndex = 105;
            this.LblPrName.Text = "نام کالا :";
            // 
            // LblPrCode
            // 
            this.LblPrCode.AutoSize = true;
            this.LblPrCode.Location = new System.Drawing.Point(12, 9);
            this.LblPrCode.Name = "LblPrCode";
            this.LblPrCode.Size = new System.Drawing.Size(43, 18);
            this.LblPrCode.TabIndex = 106;
            this.LblPrCode.Text = "کد کالا :";
            // 
            // TxtPrName
            // 
            this.TxtPrName.Location = new System.Drawing.Point(146, 31);
            this.TxtPrName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPrName.Name = "TxtPrName";
            this.TxtPrName.Size = new System.Drawing.Size(214, 26);
            this.TxtPrName.TabIndex = 104;
            this.TxtPrName.TextChanged += new System.EventHandler(this.TxtPrName_TextChanged);
            this.TxtPrName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProductSearch_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvProducts);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 262);
            this.panel1.TabIndex = 107;
            // 
            // DgvProducts
            // 
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProducts.Location = new System.Drawing.Point(0, 0);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.Size = new System.Drawing.Size(348, 262);
            this.DgvProducts.TabIndex = 0;
            this.DgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProducts_CellDoubleClick);
            this.DgvProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProductSearch_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StLblInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(372, 22);
            this.statusStrip1.TabIndex = 108;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StLblInfo
            // 
            this.StLblInfo.Name = "StLblInfo";
            this.StLblInfo.Size = new System.Drawing.Size(16, 17);
            this.StLblInfo.Text = "...";
            // 
            // FrmProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 352);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtPrName);
            this.Controls.Add(this.TxtPrCode);
            this.Controls.Add(this.LblPrName);
            this.Controls.Add(this.LblPrCode);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProductSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "جستجوی کالا";
            this.Load += new System.EventHandler(this.FrmProductSearch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProductSearch_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPrCode;
        private System.Windows.Forms.Label LblPrName;
        private System.Windows.Forms.Label LblPrCode;
        private System.Windows.Forms.TextBox TxtPrName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StLblInfo;
    }
}