namespace NewSprout
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.nametxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.mailtxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.nametxt.Location = new System.Drawing.Point(115, 12);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 26);
            this.nametxt.TabIndex = 0;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 50);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEWSPROUT | REGISTER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.passwordtxt);
            this.panel2.Controls.Add(this.mailtxt);
            this.panel2.Controls.Add(this.phonetxt);
            this.panel2.Controls.Add(this.surnametxt);
            this.panel2.Controls.Add(this.nametxt);
            this.panel2.Location = new System.Drawing.Point(50, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 227);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.passwordtxt.Location = new System.Drawing.Point(115, 192);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(100, 26);
            this.passwordtxt.TabIndex = 4;
            this.passwordtxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // mailtxt
            // 
            this.mailtxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mailtxt.Location = new System.Drawing.Point(115, 147);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(100, 26);
            this.mailtxt.TabIndex = 3;
            // 
            // phonetxt
            // 
            this.phonetxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.phonetxt.Location = new System.Drawing.Point(115, 102);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(100, 26);
            this.phonetxt.TabIndex = 2;
            // 
            // surnametxt
            // 
            this.surnametxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.surnametxt.Location = new System.Drawing.Point(115, 57);
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(100, 26);
            this.surnametxt.TabIndex = 1;
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.registerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerbtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.Location = new System.Drawing.Point(118, 337);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(100, 50);
            this.registerbtn.TabIndex = 3;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 352);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 450);
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox mailtxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}