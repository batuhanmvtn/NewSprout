namespace NewSprout
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.registerlbl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adminloginbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.usernametxt.Location = new System.Drawing.Point(133, 80);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(100, 26);
            this.usernametxt.TabIndex = 0;
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.passwordtxt.Location = new System.Drawing.Point(133, 129);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(100, 26);
            this.passwordtxt.TabIndex = 1;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(133, 189);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(100, 50);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // registerlbl
            // 
            this.registerlbl.AutoSize = true;
            this.registerlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerlbl.Location = new System.Drawing.Point(264, 321);
            this.registerlbl.Name = "registerlbl";
            this.registerlbl.Size = new System.Drawing.Size(58, 19);
            this.registerlbl.TabIndex = 3;
            this.registerlbl.TabStop = true;
            this.registerlbl.Text = "Register";
            this.registerlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerlbl_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Don\'t have an account?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Admin Login:";
            // 
            // adminloginbtn
            // 
            this.adminloginbtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.adminloginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminloginbtn.Location = new System.Drawing.Point(133, 246);
            this.adminloginbtn.Name = "adminloginbtn";
            this.adminloginbtn.Size = new System.Drawing.Size(100, 36);
            this.adminloginbtn.TabIndex = 8;
            this.adminloginbtn.Text = "Enter";
            this.adminloginbtn.UseVisualStyleBackColor = false;
            this.adminloginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 50);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "NEW SPROUT | LOGIN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(197, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminloginbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerlbl);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.LinkLabel registerlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button adminloginbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}