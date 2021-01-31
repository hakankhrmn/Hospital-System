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
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;

        }
        public string tc;
        sql_Connection cnt = new sql_Connection();

        public void getBranchTbl()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branches", cnt.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void getDoctorTbl()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Doctors", cnt.connect());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        public void getcmbB()
        {
            SqlCommand command3 = new SqlCommand("select BranchName from Tbl_Branches", cnt.connect());
            SqlDataReader rdr3 = command3.ExecuteReader();
            while (rdr3.Read())
            {
                Branches.Items.Add(rdr3[0].ToString());
            }

            cnt.connect().Close();
        }

        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            STC.Text = tc;
            
            SqlCommand command = new SqlCommand("select SecretaryNameSurname from Tbl_Secretaries where SecretaryTC=@p1",cnt.connect());
            command.Parameters.AddWithValue("@p1",tc);
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                SNameS.Text = rdr[0].ToString();
            }
            cnt.connect().Close();

            getBranchTbl();

            getDoctorTbl();

            getcmbB();

        }

        private void Branches_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctors.Items.Clear();
            SqlCommand command3 = new SqlCommand("select DoctorName, DoctorSurname from Tbl_Doctors where DoctorDepartment=@p1", cnt.connect());
            command3.Parameters.AddWithValue("@p1", Branches.Text);
            SqlDataReader rdr3 = command3.ExecuteReader();
            while (rdr3.Read())
            {
                Doctors.Items.Add(rdr3[0] + " " + rdr3[1]);
            }

            cnt.connect().Close();
        }

        private void btnASave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Appointments (AppointmentDate,AppointmentHour, AppointmentBranch, AppointmentDoctor) values (@p1,@p2,@p3,@p4) ",cnt.connect());
            command.Parameters.AddWithValue("@p1", mskDate.Text);
            command.Parameters.AddWithValue("@p2", mskHour.Text);
            command.Parameters.AddWithValue("@p3",Branches.Text);
            command.Parameters.AddWithValue("@p4", Doctors.Text);
            command.ExecuteNonQuery();
            cnt.connect().Close();
            MessageBox.Show("Saved successfuly...","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnCreateA_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Announcements (Announcement) values (@p1)", cnt.connect());
            command.Parameters.AddWithValue("@p1", rchAnnouncement.Text);
            command.ExecuteNonQuery();
            cnt.connect().Close();
            MessageBox.Show("Announcement was created...","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnDPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel fr = new FrmDoctorPanel();
            fr.Show();
        }

        private void btnBPanel_Click(object sender, EventArgs e)
        {
            FrmBranchPanel fr = new FrmBranchPanel();
            fr.Show();
        }

        private void btnAList_Click(object sender, EventArgs e)
        {
            FrmAppointmentList fr = new FrmAppointmentList();
            fr.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Branches.Items.Clear();

            getBranchTbl();

            getDoctorTbl();

            getcmbB();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;
            Branches.Text = dataGridView2.Rows[selected].Cells[2].Value.ToString();
            Doctors.Text = (dataGridView2.Rows[selected].Cells[0].Value.ToString()) + " " + (dataGridView2.Rows[selected].Cells[1].Value.ToString());
            DTC.Text = dataGridView2.Rows[selected].Cells[3].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
