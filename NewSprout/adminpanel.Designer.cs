namespace NewSprout
{
    partial class adminpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sproutsPlantedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newsproutDataSet2 = new NewSprout.newsproutDataSet2();
            this.loginTableAdapter1 = new NewSprout.newsproutDataSet2TableAdapters.loginTableAdapter();
            this.listbtn = new System.Windows.Forms.Button();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.mailtxt = new System.Windows.Forms.TextBox();
            this.sprouttxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.insertbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.temizlebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsproutDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Records";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.sproutsPlantedDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 181);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "userid";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // sproutsPlantedDataGridViewTextBoxColumn
            // 
            this.sproutsPlantedDataGridViewTextBoxColumn.DataPropertyName = "sproutsPlanted";
            this.sproutsPlantedDataGridViewTextBoxColumn.HeaderText = "sproutsPlanted";
            this.sproutsPlantedDataGridViewTextBoxColumn.Name = "sproutsPlantedDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // loginBindingSource1
            // 
            this.loginBindingSource1.DataMember = "login";
            this.loginBindingSource1.DataSource = this.newsproutDataSet2;
            // 
            // newsproutDataSet2
            // 
            this.newsproutDataSet2.DataSetName = "newsproutDataSet2";
            this.newsproutDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // listbtn
            // 
            this.listbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbtn.ForeColor = System.Drawing.Color.White;
            this.listbtn.Location = new System.Drawing.Point(14, 65);
            this.listbtn.Name = "listbtn";
            this.listbtn.Size = new System.Drawing.Size(100, 30);
            this.listbtn.TabIndex = 1;
            this.listbtn.Text = "List All";
            this.listbtn.UseVisualStyleBackColor = false;
            this.listbtn.Click += new System.EventHandler(this.listbtn_Click);
            // 
            // idtxt
            // 
            this.idtxt.Enabled = false;
            this.idtxt.Location = new System.Drawing.Point(139, 13);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 26);
            this.idtxt.TabIndex = 2;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(139, 48);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 26);
            this.nametxt.TabIndex = 3;
            // 
            // surnametxt
            // 
            this.surnametxt.Location = new System.Drawing.Point(139, 81);
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(100, 26);
            this.surnametxt.TabIndex = 4;
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(139, 114);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(100, 26);
            this.phonetxt.TabIndex = 5;
            // 
            // mailtxt
            // 
            this.mailtxt.Location = new System.Drawing.Point(139, 146);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(100, 26);
            this.mailtxt.TabIndex = 6;
            // 
            // sprouttxt
            // 
            this.sprouttxt.Location = new System.Drawing.Point(139, 179);
            this.sprouttxt.Name = "sprouttxt";
            this.sprouttxt.Size = new System.Drawing.Size(100, 26);
            this.sprouttxt.TabIndex = 7;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(139, 212);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(100, 26);
            this.passtxt.TabIndex = 8;
            // 
            // insertbtn
            // 
            this.insertbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.insertbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbtn.ForeColor = System.Drawing.Color.White;
            this.insertbtn.Location = new System.Drawing.Point(120, 35);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(100, 30);
            this.insertbtn.TabIndex = 9;
            this.insertbtn.Text = "Add New";
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.delbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.ForeColor = System.Drawing.Color.White;
            this.delbtn.Location = new System.Drawing.Point(120, 98);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(100, 30);
            this.delbtn.TabIndex = 10;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(120, 161);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(100, 30);
            this.updatebtn.TabIndex = 11;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // temizlebtn
            // 
            this.temizlebtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.temizlebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temizlebtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temizlebtn.ForeColor = System.Drawing.Color.White;
            this.temizlebtn.Location = new System.Drawing.Point(14, 130);
            this.temizlebtn.Name = "temizlebtn";
            this.temizlebtn.Size = new System.Drawing.Size(100, 30);
            this.temizlebtn.TabIndex = 12;
            this.temizlebtn.Text = "Clear All";
            this.temizlebtn.UseVisualStyleBackColor = false;
            this.temizlebtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.listbtn);
            this.panel1.Controls.Add(this.temizlebtn);
            this.panel1.Controls.Add(this.insertbtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.delbtn);
            this.panel1.Location = new System.Drawing.Point(427, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 226);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "User ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(79, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "E-Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sprouts Planted:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(61, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(728, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.sprouttxt);
            this.Controls.Add(this.mailtxt);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.surnametxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "adminpanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminpanel";
            this.Load += new System.EventHandler(this.adminpanel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsproutDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private newsproutDataSet2 newsproutDataSet2;
        private System.Windows.Forms.BindingSource loginBindingSource1;
        private newsproutDataSet2TableAdapters.loginTableAdapter loginTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sproutsPlantedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button listbtn;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox mailtxt;
        private System.Windows.Forms.TextBox sprouttxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button temizlebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}