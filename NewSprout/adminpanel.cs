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
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-Q59IS2QS\\SQLEXPRESS;Initial Catalog=newsprout;Integrated Security=True");
        private void adminpanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newsproutDataSet2.login' table. You can move, or remove it, as needed.
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listbtn_Click(object sender, EventArgs e)
        {
            this.loginTableAdapter1.Fill(this.newsproutDataSet2.login);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            idtxt.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            nametxt.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            surnametxt.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            passtxt.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            sprouttxt.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            phonetxt.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            mailtxt.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nametxt.Text = "";
            idtxt.Text = "";
            surnametxt.Text = "";
            phonetxt.Text = "";
            sprouttxt.Text = "";
            mailtxt.Text = "";
            passtxt.Text = "";

            nametxt.Focus();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into login (username, surname,password,sproutsPlanted,phonenumber,email) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", nametxt.Text);
            komut.Parameters.AddWithValue("@p2", surnametxt.Text);
            komut.Parameters.AddWithValue("@p3", passtxt.Text);
            komut.Parameters.AddWithValue("@p4", sprouttxt.Text);
            komut.Parameters.AddWithValue("@p5", phonetxt.Text);
            komut.Parameters.AddWithValue("@p6", mailtxt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Record Added.");
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete from login where userid=@u1", baglanti);
            sil.Parameters.AddWithValue("@u1", idtxt.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Record Deleted.");
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand upkomut = new SqlCommand("update login set username=@d1, surname=@d2,password=@d3,sproutsPlanted=@d4,phonenumber=@d5,email=@d6 where userid=@d7", baglanti);

            upkomut.Parameters.AddWithValue("@d1", nametxt.Text);
            upkomut.Parameters.AddWithValue("@d2", surnametxt.Text);
            upkomut.Parameters.AddWithValue("@d3", passtxt.Text);
            upkomut.Parameters.AddWithValue("@d4", sprouttxt.Text);
            upkomut.Parameters.AddWithValue("@d5", phonetxt.Text);
            upkomut.Parameters.AddWithValue("@d6", mailtxt.Text);
            upkomut.Parameters.AddWithValue("@d7", idtxt.Text);
            upkomut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Record Updated.");
        }
    }
}
