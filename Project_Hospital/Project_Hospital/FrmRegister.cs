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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        sql_Connection cnt = new sql_Connection();
        private bool isInclude = false;

        private void FrmRegister_Load(object sender, EventArgs e){}

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Patients( PatientTC,PatientName, PatientSurname, PatientNo, PatientPassword, PatientGender) values (@p1, @p2, @p3, @p4, @p5, @p6)", cnt.connect());
            SqlCommand control = new SqlCommand("select PatientTC");

            foreach (var tcno in control.Parameters)
            {
                if (tcno.Equals(PTC.Text))
                {
                   
                    isInclude = true;
                    break;
                }
            }

            if (!isInclude)
            {
                try
                {
                    command.Parameters.AddWithValue("@p1", PTC.Text);
                    command.Parameters.AddWithValue("@p2", Pname.Text);
                    command.Parameters.AddWithValue("@p3", PSurname.Text);
                    command.Parameters.AddWithValue("@p4", PTel.Text);
                    command.Parameters.AddWithValue("@p5", PPassword.Text);
                    command.Parameters.AddWithValue("@p6", PGender.SelectedItem);
                    command.ExecuteNonQuery();
                    cnt.connect().Close();
                    MessageBox.Show("Registration is succesfull. " , "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                catch (SqlException exception)
                {
                    if (exception.Number == 2627)
                    {
                        MessageBox.Show("TC No must be unique", "Registration Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Values cannot be null!..", "Registration Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PPassword.PasswordChar = '\0';
            }
            else
            {
                PPassword.PasswordChar = '●';
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString();
        }
    }
}
