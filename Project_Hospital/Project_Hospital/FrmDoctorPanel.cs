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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }
        sql_Connection cnt = new sql_Connection();
        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            getData();

            SqlCommand command = new SqlCommand("select BranchName from Tbl_Branches", cnt.connect());
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                DBranch.Items.Add(rdr[0]);
            }
            cnt.connect().Close();
                
        }
        private void getData()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Doctors", cnt.connect());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Doctors (DoctorName,DoctorSurname,DoctorDepartment,DoctorTC,DoctorPassword) values (@p1,@p2,@p3,@p4,@p5)", cnt.connect());

            try
            {
                command.Parameters.AddWithValue("@p1", Dname.Text);
                command.Parameters.AddWithValue("@p2", DSurname.Text);
                command.Parameters.AddWithValue("@p3", DBranch.Text);
                command.Parameters.AddWithValue("@p4", DTC.Text);
                command.Parameters.AddWithValue("@p5", DPassword.Text);
                command.ExecuteNonQuery();
                
                MessageBox.Show("Doctor was Added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException exception)
            {
                MessageBox.Show("There is already a registered doctor with this TC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnt.connect().Close();
                getData();
            }
            
            
            
             
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DTC.ReadOnly = false;
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            Dname.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            DSurname.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            DBranch.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            DTC.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            DPassword.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            if (!DTC.Text.Equals(""))
            {
                DTC.ReadOnly = true;
            }
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from Tbl_Doctors where DoctorTC=@p1", cnt.connect());
            command.Parameters.AddWithValue("@p1", DTC.Text);
            command.ExecuteNonQuery();
            cnt.connect().Close();
            getData();
            MessageBox.Show("Doctor was Deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Doctors set DoctorName=@p1 ,DoctorSurname=@p2 ,DoctorDepartment=@p3, DoctorPassword=@p5 where DoctorTC=@p4", cnt.connect());
            command.Parameters.AddWithValue("@p1", Dname.Text);
            command.Parameters.AddWithValue("@p2", DSurname.Text);
            command.Parameters.AddWithValue("@p3", DBranch.Text);
            command.Parameters.AddWithValue("@p4", DTC.Text);
            command.Parameters.AddWithValue("@p5", DPassword.Text);
            command.ExecuteNonQuery();
            cnt.connect().Close();
            getData();
            MessageBox.Show("Doctor was Updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }
    }
}
