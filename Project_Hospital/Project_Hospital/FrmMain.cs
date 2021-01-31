using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void patient_Click(object sender, EventArgs e)
        {
            FrmPatientLogIn fr = new FrmPatientLogIn();
            fr.ShowDialog();
            this.SendToBack();
            
           // this.Hide();
        }

        private void secretary_Click(object sender, EventArgs e)
        {
            FrmSLogIn fr = new FrmSLogIn();
            fr.ShowDialog();
            this.SendToBack();
            //this.Hide();
        }

        private void doctor_Click(object sender, EventArgs e)
        {
            FrmDoctorLogIn fr = new FrmDoctorLogIn();
            fr.ShowDialog();
            this.SendToBack();
            //this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
        }
    }
}
