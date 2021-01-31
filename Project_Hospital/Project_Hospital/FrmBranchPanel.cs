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
    public partial class FrmBranchPanel : Form
    {
        public FrmBranchPanel()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        sql_Connection cnt = new sql_Connection();
        private void getData()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Branches", cnt.connect());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Branches (BranchName) values (@p1)", cnt.connect());
            command.Parameters.AddWithValue("@p1", BranchName.Text);
            command.ExecuteNonQuery();
            cnt.connect().Close();
            getData();
            MessageBox.Show("Branch was added...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from Tbl_Branches where BranchID=@p1", cnt.connect());
            command.Parameters.AddWithValue("@p1", BranchID.Text);
            command.ExecuteNonQuery();
            cnt.connect().Close();
            getData();
            MessageBox.Show("Branch was deleted...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Branches set BranchName=@p1 where BranchID=@p2", cnt.connect());
            command.Parameters.AddWithValue("@p1", BranchName.Text);
            command.Parameters.AddWithValue("@p2", BranchID.Text);
            command.ExecuteNonQuery();
            cnt.connect().Close();
            getData();
            MessageBox.Show("Branch was updated...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            BranchID.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            BranchName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            
        }

        private void FrmBranchPanel_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
