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
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-Q59IS2QS\\SQLEXPRESS;Initial Catalog=newsprout;Integrated Security=True");
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int plant = 0;
        //plant = Convert.ToInt32(plantedlbl.Text);
        private void plantbtn_Click(object sender, EventArgs e)
        {
            plant++;
            plantedlbl.Text = plant.ToString();
            /*baglanti.Open();
            SqlCommand upkomut = new SqlCommand("update login set sproutsPlanted=@p1 where username =@p2", baglanti);

            upkomut.Parameters.AddWithValue("@p1", sprouttxt.Text);
            upkomut.Parameters.AddWithValue("@p2", usernamelbl.Text);
            upkomut.ExecuteNonQuery();
            baglanti.Close();*/
            MessageBox.Show("A new sprout planted.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mPlant = Convert.ToInt32(multitxt.Text);
            plant += mPlant;
            plantedlbl.Text = plant.ToString();
            MessageBox.Show(mPlant + " sprouts planted.");
        }

        private void ranklbl_Click(object sender, EventArgs e)
        {
            if (plant >= 0 && plant <= 20)
            {
                ranklbl.Text = "Little Sprout";
            }
            else if (plant > 20 && plant <= 50)
            {
                ranklbl.Text = "Old Tree";
            }
            else if(plant > 50 && plant <= 90)
            {
                ranklbl.Text = "King of the Forest";
            }
            else if(plant > 90)
            {
                ranklbl.Text = "Mother Nature";
            }
            else { ranklbl.Text = "ERROR";
                MessageBox.Show("An error occuredcin the ranking.");
            }
        }
    }
}
