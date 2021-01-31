namespace Project_Hospital
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.PTC = new System.Windows.Forms.MaskedTextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PTel = new System.Windows.Forms.MaskedTextBox();
            this.PGender = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PTC
            // 
            this.PTC.Location = new System.Drawing.Point(173, 136);
            this.PTC.Mask = "00000000000";
            this.PTC.Name = "PTC";
            this.PTC.Size = new System.Drawing.Size(222, 36);
            this.PTC.TabIndex = 3;
            this.PTC.ValidatingType = typeof(int);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnRegister.Location = new System.Drawing.Point(233, 304);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(117, 44);
            this.BtnRegister.TabIndex = 12;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Patient TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phone No:";
            // 
            // PPassword
            // 
            this.PPassword.Location = new System.Drawing.Point(173, 220);
            this.PPassword.Name = "PPassword";
            this.PPassword.PasswordChar = '●';
            this.PPassword.Size = new System.Drawing.Size(137, 36);
            this.PPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password:";
            // 
            // PSurname
            // 
            this.PSurname.Location = new System.Drawing.Point(173, 94);
            this.PSurname.Name = "PSurname";
            this.PSurname.Size = new System.Drawing.Size(222, 36);
            this.PSurname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Surname:";
            // 
            // Pname
            // 
            this.Pname.Location = new System.Drawing.Point(173, 52);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(222, 36);
            this.Pname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Name:";
            // 
            // PTel
            // 
            this.PTel.Location = new System.Drawing.Point(173, 178);
            this.PTel.Mask = "(999) 000-0000";
            this.PTel.Name = "PTel";
            this.PTel.Size = new System.Drawing.Size(222, 36);
            this.PTel.TabIndex = 4;
            // 
            // PGender
            // 
            this.PGender.FormattingEnabled = true;
            this.PGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PGender.Location = new System.Drawing.Point(173, 262);
            this.PGender.Name = "PGender";
            this.PGender.Size = new System.Drawing.Size(222, 36);
            this.PGender.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(316, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(193, 33);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 29);
            this.label7.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 23;
            // 
            // FrmRegister
            // 
            this.AcceptButton = this.BtnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(463, 386);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PGender);
            this.Controls.Add(this.PTel);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PSurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PTC);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Page";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox PTC;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox PTel;
        private System.Windows.Forms.ComboBox PGender;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
    }
}