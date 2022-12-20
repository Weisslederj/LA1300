using LA_1300V4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA_1300V4
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();



            int[] values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            string[] colors = { "Red", "Yellow", "Green", "Blue" };


            Image[] images = { Properties.Resources.Red_0, Properties.Resources.Red_1, Properties.Resources.Red_2, Properties.Resources.Red_3, Properties.Resources.Red_4, Properties.Resources.Red_5, Properties.Resources.Red_6, Properties.Resources.Red_7, Properties.Resources.Red_8, Properties.Resources.Red_9,
            Properties.Resources.Yellow_0,Properties.Resources.Yellow_1, Properties.Resources.Yellow_2, Properties.Resources.Yellow_3,Properties.Resources.Yellow_4,Properties.Resources.Yellow_5, Properties.Resources.Yellow_6,Properties.Resources.Yellow_7,Properties.Resources.Yellow_8, Properties.Resources.Yellow_9,
            Properties.Resources.Green_0, Properties.Resources.Green_1,Properties.Resources.Green_2, Properties.Resources.Green_3, Properties.Resources.Green_4, Properties.Resources.Green_5, Properties.Resources.Green_6, Properties.Resources.Green_7,Properties.Resources.Green_8, Properties.Resources.Green_9,
            Properties.Resources.Blue_0, Properties.Resources.Blue_1,Properties.Resources.Blue_2,Properties.Resources.Blue_3,Properties.Resources.Blue_4,Properties.Resources.Blue_5,Properties.Resources.Blue_6,Properties.Resources.Blue_7,Properties.Resources.Blue_8,Properties.Resources.Blue_9,};



            List<Card> cards = new List<Card>();







            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < colors.Length; j++)
                {

                    Card card = new Card(values[i], colors[j], images[i]);


                    cards.Add(card);
                }
            }



            Deck deck = new Deck(cards);


            foreach (Player player in players)
            {
                player.DrawCards(deck, 7);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();
            pictureBox9.Show();
            pictureBox10.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox6.Location = new Point(339, 92);
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
             pictureBox2.Location = new Point(339, 92);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox7.Location = new Point(339, 92);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox5.Location = new Point(339, 92);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Location = new Point(339, 92);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(339, 92);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(339, 92);
        }
    }

}
