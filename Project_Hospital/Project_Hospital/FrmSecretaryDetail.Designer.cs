namespace Project_Hospital
{
    partial class FrmSecretaryDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaryDetail));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateA = new System.Windows.Forms.Button();
            this.rchAnnouncement = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SNameS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.STC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnASave = new System.Windows.Forms.Button();
            this.chkSituation = new System.Windows.Forms.CheckBox();
            this.Doctors = new System.Windows.Forms.ComboBox();
            this.Branches = new System.Windows.Forms.ComboBox();
            this.mskHour = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTC = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAList = new System.Windows.Forms.Button();
            this.btnBPanel = new System.Windows.Forms.Button();
            this.btnDPanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(808, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 280);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Branches";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(448, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateA);
            this.groupBox2.Controls.Add(this.rchAnnouncement);
            this.groupBox2.Location = new System.Drawing.Point(26, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 296);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Announcement";
            // 
            // btnCreateA
            // 
            this.btnCreateA.Location = new System.Drawing.Point(93, 230);
            this.btnCreateA.Name = "btnCreateA";
            this.btnCreateA.Size = new System.Drawing.Size(163, 37);
            this.btnCreateA.TabIndex = 26;
            this.btnCreateA.Text = "Create";
            this.btnCreateA.UseVisualStyleBackColor = true;
            this.btnCreateA.Click += new System.EventHandler(this.btnCreateA_Click);
            // 
            // rchAnnouncement
            // 
            this.rchAnnouncement.Location = new System.Drawing.Point(0, 35);
            this.rchAnnouncement.Name = "rchAnnouncement";
            this.rchAnnouncement.Size = new System.Drawing.Size(348, 189);
            this.rchAnnouncement.TabIndex = 25;
            this.rchAnnouncement.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SNameS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.STC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 148);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Info";
            // 
            // SNameS
            // 
            this.SNameS.AutoSize = true;
            this.SNameS.Location = new System.Drawing.Point(186, 97);
            this.SNameS.Name = "SNameS";
            this.SNameS.Size = new System.Drawing.Size(50, 29);
            this.SNameS.TabIndex = 24;
            this.SNameS.Text = "null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name Surname:";
            // 
            // STC
            // 
            this.STC.AutoSize = true;
            this.STC.Location = new System.Drawing.Point(186, 44);
            this.STC.Name = "STC";
            this.STC.Size = new System.Drawing.Size(145, 29);
            this.STC.TabIndex = 22;
            this.STC.Text = "00000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Secretary TC:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.btnASave);
            this.groupBox4.Controls.Add(this.chkSituation);
            this.groupBox4.Controls.Add(this.Doctors);
            this.groupBox4.Controls.Add(this.Branches);
            this.groupBox4.Controls.Add(this.mskHour);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.mskDate);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.DTC);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(405, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 471);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Appointment Panel";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(89, 380);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(247, 73);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.Text = "Refresh Tables";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnASave
            // 
            this.btnASave.Location = new System.Drawing.Point(174, 286);
            this.btnASave.Name = "btnASave";
            this.btnASave.Size = new System.Drawing.Size(176, 48);
            this.btnASave.TabIndex = 56;
            this.btnASave.Text = "Save";
            this.btnASave.UseVisualStyleBackColor = true;
            this.btnASave.Click += new System.EventHandler(this.btnASave_Click);
            // 
            // chkSituation
            // 
            this.chkSituation.AutoSize = true;
            this.chkSituation.Location = new System.Drawing.Point(160, 252);
            this.chkSituation.Name = "chkSituation";
            this.chkSituation.Size = new System.Drawing.Size(126, 33);
            this.chkSituation.TabIndex = 55;
            this.chkSituation.Text = "Situation";
            this.chkSituation.UseVisualStyleBackColor = true;
            // 
            // Doctors
            // 
            this.Doctors.FormattingEnabled = true;
            this.Doctors.Location = new System.Drawing.Point(142, 170);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(222, 36);
            this.Doctors.TabIndex = 5;
            // 
            // Branches
            // 
            this.Branches.FormattingEnabled = true;
            this.Branches.Location = new System.Drawing.Point(142, 128);
            this.Branches.Name = "Branches";
            this.Branches.Size = new System.Drawing.Size(222, 36);
            this.Branches.TabIndex = 4;
            this.Branches.SelectedIndexChanged += new System.EventHandler(this.Branches_SelectedIndexChanged);
            // 
            // mskHour
            // 
            this.mskHour.Location = new System.Drawing.Point(142, 86);
            this.mskHour.Mask = "00:00";
            this.mskHour.Name = "mskHour";
            this.mskHour.Size = new System.Drawing.Size(222, 36);
            this.mskHour.TabIndex = 3;
            this.mskHour.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 29);
            this.label7.TabIndex = 51;
            this.label7.Text = "Hour:";
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(142, 44);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(222, 36);
            this.mskDate.TabIndex = 2;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 44;
            this.label5.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "Doctor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 41;
            this.label3.Text = "Branch:";
            // 
            // DTC
            // 
            this.DTC.Location = new System.Drawing.Point(142, 212);
            this.DTC.Mask = "00000000000";
            this.DTC.Name = "DTC";
            this.DTC.Size = new System.Drawing.Size(222, 36);
            this.DTC.TabIndex = 6;
            this.DTC.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 29);
            this.label8.TabIndex = 37;
            this.label8.Text = "Doctor TC:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(811, 313);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(451, 302);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(445, 267);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btnAList);
            this.groupBox6.Controls.Add(this.btnBPanel);
            this.groupBox6.Controls.Add(this.btnDPanel);
            this.groupBox6.Location = new System.Drawing.Point(26, 510);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(776, 105);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rapid-Access";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 48);
            this.button1.TabIndex = 60;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAList
            // 
            this.btnAList.Location = new System.Drawing.Point(379, 35);
            this.btnAList.Name = "btnAList";
            this.btnAList.Size = new System.Drawing.Size(199, 48);
            this.btnAList.TabIndex = 59;
            this.btnAList.Text = "Appointment List";
            this.btnAList.UseVisualStyleBackColor = true;
            this.btnAList.Click += new System.EventHandler(this.btnAList_Click);
            // 
            // btnBPanel
            // 
            this.btnBPanel.Location = new System.Drawing.Point(191, 35);
            this.btnBPanel.Name = "btnBPanel";
            this.btnBPanel.Size = new System.Drawing.Size(172, 48);
            this.btnBPanel.TabIndex = 58;
            this.btnBPanel.Text = "Branch Panel";
            this.btnBPanel.UseVisualStyleBackColor = true;
            this.btnBPanel.Click += new System.EventHandler(this.btnBPanel_Click);
            // 
            // btnDPanel
            // 
            this.btnDPanel.Location = new System.Drawing.Point(11, 35);
            this.btnDPanel.Name = "btnDPanel";
            this.btnDPanel.Size = new System.Drawing.Size(169, 48);
            this.btnDPanel.TabIndex = 57;
            this.btnDPanel.Text = "Doctor Panel";
            this.btnDPanel.UseVisualStyleBackColor = true;
            this.btnDPanel.Click += new System.EventHandler(this.btnDPanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1080, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 35;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSecretaryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1274, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSecretaryDetail";
            this.Text = "Secretary Detail";
            this.Load += new System.EventHandler(this.FrmSecretaryDetail_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchAnnouncement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SNameS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label STC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnASave;
        private System.Windows.Forms.CheckBox chkSituation;
        private System.Windows.Forms.ComboBox Doctors;
        private System.Windows.Forms.ComboBox Branches;
        private System.Windows.Forms.MaskedTextBox mskHour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox DTC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAList;
        private System.Windows.Forms.Button btnBPanel;
        private System.Windows.Forms.Button btnDPanel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}