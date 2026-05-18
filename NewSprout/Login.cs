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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-Q59IS2QS\\SQLEXPRESS;Initial Catalog=newsprout;Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From login where username=@p1 And password=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", usernametxt.Text);
            komut.Parameters.AddWithValue("@p2", passwordtxt.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                anamenu m = new anamenu();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From admin where adminname=@p1 And adminpass=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", usernametxt.Text);
            komut.Parameters.AddWithValue("@p2", passwordtxt.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                adminpanel a = new adminpanel();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Are you sure you are an admin?");
            }
            baglanti.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void registerlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }
    }
}
