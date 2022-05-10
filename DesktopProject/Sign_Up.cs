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
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Methods m = new Methods();
                m.InsertUser(textBox1.Text, textBox3.Text, textBox2.Text);
                MessageBox.Show("Succecfully signed up");
            }
            catch (Exception)
            {
                MessageBox.Show("Username already exist.Please sign up another username");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '●')
            {
                pictureBox9.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                pictureBox8.BringToFront();
                textBox2.PasswordChar = '●';
            }
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = false;
        }
    }
}
