namespace Project_Hospital
{
    partial class FrmDEditInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDEditInfo));
            this.Dname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTC = new System.Windows.Forms.MaskedTextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DBranch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Dname
            // 
            this.Dname.Location = new System.Drawing.Point(164, 31);
            this.Dname.Name = "Dname";
            this.Dname.Size = new System.Drawing.Size(222, 36);
            this.Dname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 46;
            this.label6.Text = "Name:";
            // 
            // DSurname
            // 
            this.DSurname.Location = new System.Drawing.Point(164, 73);
            this.DSurname.Name = "DSurname";
            this.DSurname.Size = new System.Drawing.Size(222, 36);
            this.DSurname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 44;
            this.label5.Text = "Surname:";
            // 
            // DPassword
            // 
            this.DPassword.Location = new System.Drawing.Point(164, 199);
            this.DPassword.Name = "DPassword";
            this.DPassword.Size = new System.Drawing.Size(222, 36);
            this.DPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "Password:";
            // 
            // DTC
            // 
            this.DTC.Location = new System.Drawing.Point(164, 115);
            this.DTC.Mask = "00000000000";
            this.DTC.Name = "DTC";
            this.DTC.ReadOnly = true;
            this.DTC.Size = new System.Drawing.Size(222, 36);
            this.DTC.TabIndex = 3;
            this.DTC.ValidatingType = typeof(int);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Red;
            this.BtnEdit.Location = new System.Drawing.Point(220, 241);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(117, 44);
            this.BtnEdit.TabIndex = 39;
            this.BtnEdit.Text = "Update";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Doctor TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Branch:";
            // 
            // DBranch
            // 
            this.DBranch.FormattingEnabled = true;
            this.DBranch.Location = new System.Drawing.Point(164, 157);
            this.DBranch.Name = "DBranch";
            this.DBranch.Size = new System.Drawing.Size(222, 36);
            this.DBranch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 47;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDEditInfo
            // 
            this.AcceptButton = this.BtnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(417, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DBranch);
            this.Controls.Add(this.Dname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DSurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTC);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDEditInfo";
            this.Text = "Edit Info";
            this.Load += new System.EventHandler(this.FrmDEditInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Dname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox DTC;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}