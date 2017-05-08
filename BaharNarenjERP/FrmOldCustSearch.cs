using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaharNarenjERP
{
    public partial class FrmOldCustSearch : Form
    {
        public FrmOldCustSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new FrmInvoice {MdiParent = this};
            f.Show();
        }
    }
}
