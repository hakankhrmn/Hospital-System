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
    public partial class FrmSLogIn : Form
    {
        public FrmSLogIn()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled=true;
        }

        
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            sql_Connection cnt = new sql_Connection();
            SqlCommand command = new SqlCommand("select * from Tbl_Secretaries where SecretaryTC=@p1 and SecretaryPassword=@p2", cnt.connect());
            command.Parameters.AddWithValue("@p1", STC.Text);
            command.Parameters.AddWithValue("@p2", SPassword.Text);
            
            SqlDataReader rdr = command.ExecuteReader();
            if (rdr.Read())
            {
                FrmSecretaryDetail fr = new FrmSecretaryDetail();
                
                fr.tc = STC.Text;
                fr.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("TC no or Password is wrong...", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cnt.connect().Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }
    }
}
