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
    public partial class FrmPEditInfo : Form
    {
        public FrmPEditInfo()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        public string TCno;
        private void FrmPEditInfo_Load(object sender, EventArgs e)
        {
            sql_Connection cnt = new sql_Connection();
            SqlCommand command = new SqlCommand("select * from Tbl_Patients where PatientTC='"+TCno+"'",cnt.connect());
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                PTC.Text = rdr[0].ToString();
                Pname.Text = rdr[1].ToString();
                PSurname.Text = rdr[2].ToString();
                PTel.Text = rdr[3].ToString();
                PPassword.Text = rdr[4].ToString();
                PGender.Text = rdr[5].ToString();
            }
            cnt.connect().Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            sql_Connection cnt = new sql_Connection();
            SqlCommand command = new SqlCommand("update Tbl_Patients set PatientName=@p1, PatientSurname=@p2, PatientNo=@p4, PatientPassword=@p5, PatientGender=@p6 where PatientTC=@p3",cnt.connect());
            if (Pname.Text.Equals("") | PSurname.Text.Equals("") | PTel.Text.Equals("") |
                PPassword.Text.Equals("") | PGender.Text.Equals(""))
            {
                MessageBox.Show("Please fill the blanks...", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                command.Parameters.AddWithValue("@p1", Pname.Text);
                command.Parameters.AddWithValue("@p2", PSurname.Text);
                command.Parameters.AddWithValue("@p4", PTel.Text);
                command.Parameters.AddWithValue("@p5", PPassword.Text);
                command.Parameters.AddWithValue("@p6", PGender.Text);
                command.ExecuteNonQuery();
                cnt.connect().Close();
                MessageBox.Show("Your information was updated...", "Information", MessageBoxButtons.OK);
            }
            
                
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }
    }
}
