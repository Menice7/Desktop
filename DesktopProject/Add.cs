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

namespace DesktopProject
{
    public partial class Add : Form
    {
        
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            methods.AddCompany(textBox2.Text, (int)comboBox3.SelectedValue,
                0, Convert.ToInt32(textBox4.Text));
            MessageBox.Show("Succesfully added");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Methods methods = new Methods();
            methods.AddComputer(textBox8.Text, Int32.Parse( textBox7.Text),
            dateTimePicker1.Text,(int)comboBox1.SelectedValue , (int)comboBox2.SelectedValue);
            methods.UpdateTotalNumber();
            MessageBox.Show("Succesfully added");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {
            Methods m = new Methods();
            comboBox1.DataSource= m.ListCompany();
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.ValueMember = "CompanyId";

            comboBox2.DataSource = m.ListUser();
            comboBox2.DisplayMember = "UserName";
            comboBox2.ValueMember = "UserId";

            comboBox3.DataSource = m.ListUser();
            comboBox3.DisplayMember = "UserName";
            comboBox3.ValueMember = "UserId";

            
            //DataTable dt = new DataTable();
            //string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            //SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            //con.Open();
            //string query = @"select c.CompanyId,CompanyName from Computer c
            //                 inner join ComputerCompanies cc on c.CompanyId = cc.CompanyId";
            //SqlDataAdapter sqldataadapter = new SqlDataAdapter(query,con);
            //sqldataadapter.Fill(dt);
            //comboBox1.DataSource = dt;
            //comboBox1.DisplayMember=


            //con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.ShowDialog();
        }
    }
}
