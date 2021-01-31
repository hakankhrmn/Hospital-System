namespace Project_Hospital
{
    partial class FrmPEditInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPEditInfo));
            this.PGender = new System.Windows.Forms.ComboBox();
            this.PTel = new System.Windows.Forms.MaskedTextBox();
            this.Pname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PTC = new System.Windows.Forms.MaskedTextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PGender
            // 
            this.PGender.FormattingEnabled = true;
            this.PGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PGender.Location = new System.Drawing.Point(161, 254);
            this.PGender.Name = "PGender";
            this.PGender.Size = new System.Drawing.Size(222, 36);
            this.PGender.TabIndex = 36;
            // 
            // PTel
            // 
            this.PTel.Location = new System.Drawing.Point(161, 170);
            this.PTel.Mask = "(999) 000-0000";
            this.PTel.Name = "PTel";
            this.PTel.Size = new System.Drawing.Size(222, 36);
            this.PTel.TabIndex = 35;
            // 
            // Pname
            // 
            this.Pname.Location = new System.Drawing.Point(161, 44);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(222, 36);
            this.Pname.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Name:";
            // 
            // PSurname
            // 
            this.PSurname.Location = new System.Drawing.Point(161, 86);
            this.PSurname.Name = "PSurname";
            this.PSurname.Size = new System.Drawing.Size(222, 36);
            this.PSurname.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Surname:";
            // 
            // PPassword
            // 
            this.PPassword.Location = new System.Drawing.Point(161, 212);
            this.PPassword.Name = "PPassword";
            this.PPassword.Size = new System.Drawing.Size(222, 36);
            this.PPassword.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Phone No:";
            // 
            // PTC
            // 
            this.PTC.Location = new System.Drawing.Point(161, 128);
            this.PTC.Mask = "00000000000";
            this.PTC.Name = "PTC";
            this.PTC.ReadOnly = true;
            this.PTC.Size = new System.Drawing.Size(222, 36);
            this.PTC.TabIndex = 27;
            this.PTC.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.PTC.ValidatingType = typeof(int);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Red;
            this.BtnEdit.Location = new System.Drawing.Point(254, 306);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(117, 44);
            this.BtnEdit.TabIndex = 26;
            this.BtnEdit.Text = "Update";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Patient TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 29);
            this.label7.TabIndex = 37;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPEditInfo
            // 
            this.AcceptButton = this.BtnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(437, 392);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPEditInfo";
            this.Text = "Edit Info";
            this.Load += new System.EventHandler(this.FrmPEditInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PGender;
        private System.Windows.Forms.MaskedTextBox PTel;
        private System.Windows.Forms.TextBox Pname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox PTC;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}