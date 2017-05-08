using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaharNarenjERP
{
    public partial class FrmPersonnel : Form
    {
        private readonly DataTable _dt = new DataTable();
        private readonly MySqlDataAdapter _da = new MySqlDataAdapter();
        private readonly BindingSource _bs = new BindingSource();

        private const string BaseQuery =
            @"SELECT persID AS `شماره پرسنلی`, persFName AS `نام`, persLName AS `نام خانوادگی`";
        public FrmPersonnel()
        {
            InitializeComponent();
        }

        private void FrmPersonnel_Load(object sender, EventArgs e)
        {

        }
    }
}
