using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Future
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            Show.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Hide();
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string name = textBox1.Text;
                string surname = textBox2.Text;
                Random r1 = new Random();
                int i;
                string[] show1 = new string[8];
                string[] arr = { "Engineer", "Doctor", "Lawyer", "Pilate", "Actor/Actress", "Entrepreneur", "Insurance Agent", "Athlete" };
                int num = r1.Next(0,8);
                try
                {
                    for (i = 0; i < arr.Length; i++)
                    {
                        if (num == i)
                        {
                            Show.Text = "Hey" + " " + name + " " + surname + " " + "you are going to become" + " " + arr[i] + " " + "as per my prediction";
                            
                        }
                    }
                    Show.Show();
                }

                catch (Exception e1)
                {
                    MessageBox.Show("Something Went Wrong");
                }

            }
            else
            {
                MessageBox.Show("Please Enter Required Information");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Show();
            Show.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }
    }
}
