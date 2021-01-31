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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        public string tc;
        sql_Connection cnt = new sql_Connection();

        private void lnkEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPEditInfo fr = new FrmPEditInfo();
            fr.TCno = tc;
            fr.Show();
        }

        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            PTC.Text = tc;
            SqlCommand command = new SqlCommand("select PatientName, PatientSurname from Tbl_Patients where PatientTC =@p1",cnt.connect());
            command.Parameters.AddWithValue("@p1",PTC.Text);
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                PNameS.Text=rdr[0]+" "+ rdr[1];
            }
            cnt.connect().Close();


            getAppointments();


            SqlCommand command2 = new SqlCommand("select BranchName from Tbl_Branches",cnt.connect());
            SqlDataReader rdr2 = command2.ExecuteReader();
            while (rdr2.Read())
            {
                Branch.Items.Add(rdr2[0]);
            }

            cnt.connect().Close();


        }

        private void Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctor.Items.Clear();
            Doctor.Text = "";
            SqlCommand command3 = new SqlCommand("select DoctorName, DoctorSurname from Tbl_Doctors where DoctorDepartment=@p1", cnt.connect());
            command3.Parameters.AddWithValue("@p1", Branch.Text);
            SqlDataReader rdr3 = command3.ExecuteReader();
            while (rdr3.Read())
            {
                Doctor.Items.Add(rdr3[0]+" "+rdr3[1]);
            }

            cnt.connect().Close();
        }

        private void Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAvailableAppointments();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;
            txtAppointmentID.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString();
        }

        private void btnTakeA_Click(object sender, EventArgs e)
        {
            string situation="";

            SqlCommand command2 = new SqlCommand("select AppointmentSituation from Tbl_Appointments where AppointmentId =@p1", cnt.connect());
            command2.Parameters.AddWithValue("@p1", txtAppointmentID.Text);
            SqlDataReader rdr = command2.ExecuteReader();
            while (rdr.Read())
            {
                situation = rdr[0].ToString();
            }
            cnt.connect().Close();

            if (situation != "True")
            {
                if (txtAppointmentID.Text.Equals(""))
                {
                    MessageBox.Show("Choose an appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
                else
                {
                    SqlCommand command = new SqlCommand("update Tbl_Appointments set Complaint=@p1,AppointmentSituation='1', PatientTC=@p2 where AppointmentId=@p3", cnt.connect());
                    command.Parameters.AddWithValue("@p1", richTextBox1.Text);
                    command.Parameters.AddWithValue("@p2", PTC.Text);
                    command.Parameters.AddWithValue("@p3", txtAppointmentID.Text);
                    command.ExecuteNonQuery();


                    getAppointments();
                    getAvailableAppointments();


                    cnt.connect().Close();
                    MessageBox.Show("Taked an appointment...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("The apppointment is full", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        public void getAvailableAppointments()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AppointmentId,AppointmentDate,AppointmentHour,AppointmentDoctor from Tbl_Appointments where AppointmentDoctor='" + Doctor.Text + "' and AppointmentSituation='"+0+"'", cnt.connect());
            
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            


        }

        public void getAppointments()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Appointments where PatientTC=" + tc, cnt.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
