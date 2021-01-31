using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Hospital
{
    public partial class FrmDoctorDetail : Form
    {
        public FrmDoctorDetail()
        {
            InitializeComponent();
            timer1.Start();
        }

        public string tc;
        sql_Connection cnt = new sql_Connection();

        private void FrmDoctorDetail_Load(object sender, EventArgs e)
        {
            DTC.Text = tc;
            SqlCommand command = new SqlCommand("select DoctorName, DoctorSurname from Tbl_Doctors where DoctorTC =@p1", cnt.connect());
            command.Parameters.AddWithValue("@p1", DTC.Text);
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                DNameS.Text = rdr[0] + " " + rdr[1];
            }
            cnt.connect().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Appointments where AppointmentDoctor='" + DNameS.Text + "'", cnt.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            rchComplaint.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }

        private void btnEditD_Click(object sender, EventArgs e)
        {
            FrmDEditInfo fr = new FrmDEditInfo();
            fr.tc = tc;
            fr.Show();
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            FrmAnnouncements fr = new FrmAnnouncements();
            fr.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
