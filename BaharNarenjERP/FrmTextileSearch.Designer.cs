namespace BaharNarenjERP
{
    partial class FrmTextileSearch
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
            this.DgvTextile = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StLblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.PnlDgv = new System.Windows.Forms.Panel();
            this.TxtTxName = new System.Windows.Forms.TextBox();
            this.TxtTxCode = new System.Windows.Forms.TextBox();
            this.LblTxName = new System.Windows.Forms.Label();
            this.LblTxCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTextile)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.PnlDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvTextile
            // 
            this.DgvTextile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTextile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvTextile.Location = new System.Drawing.Point(0, 0);
            this.DgvTextile.Name = "DgvTextile";
            this.DgvTextile.Size = new System.Drawing.Size(348, 262);
            this.DgvTextile.TabIndex = 0;
            this.DgvTextile.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTextile_CellDoubleClick);
            this.DgvTextile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvTextile_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StLblInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(369, 22);
            this.statusStrip1.TabIndex = 114;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StLblInfo
            // 
            this.StLblInfo.Name = "StLblInfo";
            this.StLblInfo.Size = new System.Drawing.Size(16, 17);
            this.StLblInfo.Text = "...";
            // 
            // PnlDgv
            // 
            this.PnlDgv.Controls.Add(this.DgvTextile);
            this.PnlDgv.Location = new System.Drawing.Point(12, 60);
            this.PnlDgv.Name = "PnlDgv";
            this.PnlDgv.Size = new System.Drawing.Size(348, 262);
            this.PnlDgv.TabIndex = 113;
            // 
            // TxtTxName
            // 
            this.TxtTxName.Location = new System.Drawing.Point(146, 27);
            this.TxtTxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTxName.Name = "TxtTxName";
            this.TxtTxName.Size = new System.Drawing.Size(214, 26);
            this.TxtTxName.TabIndex = 109;
            this.TxtTxName.TextChanged += new System.EventHandler(this.TxtTxName_TextChanged);
            this.TxtTxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvTextile_KeyDown);
            // 
            // TxtTxCode
            // 
            this.TxtTxCode.Location = new System.Drawing.Point(12, 27);
            this.TxtTxCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTxCode.Name = "TxtTxCode";
            this.TxtTxCode.Size = new System.Drawing.Size(128, 26);
            this.TxtTxCode.TabIndex = 110;
            this.TxtTxCode.TextChanged += new System.EventHandler(this.TxtTxCode_TextChanged);
            this.TxtTxCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvTextile_KeyDown);
            // 
            // LblTxName
            // 
            this.LblTxName.AutoSize = true;
            this.LblTxName.Location = new System.Drawing.Point(143, 5);
            this.LblTxName.Name = "LblTxName";
            this.LblTxName.Size = new System.Drawing.Size(54, 18);
            this.LblTxName.TabIndex = 111;
            this.LblTxName.Text = "نام پارچه :";
            // 
            // LblTxCode
            // 
            this.LblTxCode.AutoSize = true;
            this.LblTxCode.Location = new System.Drawing.Point(12, 5);
            this.LblTxCode.Name = "LblTxCode";
            this.LblTxCode.Size = new System.Drawing.Size(53, 18);
            this.LblTxCode.TabIndex = 112;
            this.LblTxCode.Text = "کد پارچه :";
            // 
            // FrmTextileSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 350);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PnlDgv);
            this.Controls.Add(this.TxtTxName);
            this.Controls.Add(this.TxtTxCode);
            this.Controls.Add(this.LblTxName);
            this.Controls.Add(this.LblTxCode);
            this.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTextileSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "جستجوی پارچه";
            this.Load += new System.EventHandler(this.FrmTextileSearch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvTextile_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTextile)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.PnlDgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTextile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StLblInfo;
        private System.Windows.Forms.Panel PnlDgv;
        private System.Windows.Forms.TextBox TxtTxName;
        private System.Windows.Forms.TextBox TxtTxCode;
        private System.Windows.Forms.Label LblTxName;
        private System.Windows.Forms.Label LblTxCode;
    }
}