using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class FrmAnnouncements : Form
    {
        public FrmAnnouncements()
        {
            InitializeComponent();
        }
        sql_Connection cnt = new sql_Connection();
        private void FrmAnnouncements_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Announcements", cnt.connect());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
    }
}
