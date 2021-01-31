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
    public partial class FrmDEditInfo : Form
    {
        public FrmDEditInfo()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        public string tc;
        sql_Connection cnt = new sql_Connection();
        private void FrmDEditInfo_Load(object sender, EventArgs e)
        {
            DTC.Text = tc;
            SqlCommand command = new SqlCommand("select * from Tbl_Doctors where DoctorTC=@p1", cnt.connect());
            command.Parameters.AddWithValue("@p1", tc);
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                Dname.Text = rdr[0].ToString();
                DSurname.Text = rdr[1].ToString();
                DBranch.Text = rdr[2].ToString();
                DPassword.Text = rdr[4].ToString();
            }
            cnt.connect().Close();

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Doctors set DoctorName=@p1,DoctorSurname=@p2, DoctorDepartment=@p3,DoctorPassword=@p4 where DoctorTC=@p5", cnt.connect());
            command.Parameters.AddWithValue("@p1",Dname.Text);
            command.Parameters.AddWithValue("@p2", DSurname.Text);
            command.Parameters.AddWithValue("@p3", DBranch.Text);
            command.Parameters.AddWithValue("@p4", DPassword.Text);
            command.Parameters.AddWithValue("@p5", tc);
            command.ExecuteNonQuery();
            cnt.connect().Close();
            MessageBox.Show("Your information was updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
