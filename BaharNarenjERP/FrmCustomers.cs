using System;
using System.Windows.Forms;

namespace BaharNarenjERP
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            CmbGender.Items.Add("زن");
            CmbGender.Items.Add("مرد");
            CmbGender.SelectedIndex = 0;
        }
    }
}
