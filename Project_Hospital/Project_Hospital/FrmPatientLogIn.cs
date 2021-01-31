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
    public partial class FrmPatientLogIn : Form
    {
        public FrmPatientLogIn()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        sql_Connection cnt = new sql_Connection();

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_Patients Where PatientTC=@p1 and PatientPassword=@p2",cnt.connect());
            command.Parameters.AddWithValue("@p1",PTC.Text);
            command.Parameters.AddWithValue("@p2",PPassword.Text);
            SqlDataReader rdr = command.ExecuteReader();

            if (rdr.Read()) {
                FrmPatientDetail fr = new FrmPatientDetail();
                fr.tc = PTC.Text;
                fr.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Patient TC or Password is wrong...", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cnt.connect().Close();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister fr = new FrmRegister();
            fr.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }
    }
}
