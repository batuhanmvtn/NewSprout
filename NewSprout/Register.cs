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

namespace NewSprout
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-Q59IS2QS\\SQLEXPRESS;Initial Catalog=newsprout;Integrated Security=True");


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into login (username,surname,phonenumber,email,password) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", nametxt.Text);
            komut.Parameters.AddWithValue("@p2", surnametxt.Text);
            komut.Parameters.AddWithValue("@p3", phonetxt.Text);
            komut.Parameters.AddWithValue("@p4", mailtxt.Text);
            komut.Parameters.AddWithValue("@p5", passwordtxt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            if (DialogResult.OK== MessageBox.Show("You can login to your new account.", "Login", MessageBoxButtons.OK))
            {
                Login l = new Login();
                l.Show();
                this.Hide();
            }
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
