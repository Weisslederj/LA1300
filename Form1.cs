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
