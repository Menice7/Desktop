using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up s = new Sign_Up();
            this.Hide();
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            bool b = m.SelectUser(textBox1.Text, textBox2.Text);
            if (b == true)
            {
                MessageBox.Show($"Hello, {textBox1.Text}. You succesfully signed in");
                MainForm mf = new MainForm();
                this.Hide();
                mf.ShowDialog();

            }
            else
            {
                MessageBox.Show("Doesnt match");
            }
        }
        
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '●')
            {
                pictureBox7.BringToFront();
                textBox2.PasswordChar = '\0';
            }
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                pictureBox8.BringToFront();
                textBox2.PasswordChar = '●';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox8.BringToFront();
            
            
        }
    }
}
