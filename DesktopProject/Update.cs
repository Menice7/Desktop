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
    public partial class Update : Form
    {
        int? companyid;
        string companyname;
        int? userid;
        int? totalnumber;
        int? number;
        int? computerid;
        string computerbrand;
        int? addnumber;
        DateTime? date;
        int? companyidf;
        int? useridf;
        int? useridu;
        string username;
        string email;
        string password;
        public Update(int? companyid, string companyname, int? userid, int? totalnumber,
            int? number,                    int? computerid,string computerbrand, int? addnumber, 
            DateTime? date, int? companyidf,int? useridf,int? useridu,string username,string email,string password)
        {
            
            this.companyid = companyid;
            this.companyname = companyname;
            this.userid = userid;
            this.totalnumber = totalnumber;
            this.number = number;
            this.computerid = computerid;
            this.computerbrand = computerbrand;
            this.addnumber = addnumber;
            this.date = date;
            this.companyidf = companyidf;
            this.useridf = useridf;
            this.useridu = useridu;
            this.username = username;
            this.email = email;
            this.password = password;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            m.UpdateCompany(Int32.Parse( textBox1.Text),textBox2.Text,(int)comboBox1.SelectedValue,
                Int32.Parse(textBox5.Text) ,Int32.Parse(textBox4.Text) );
            m.UpdateTotalNumber();
            MessageBox.Show("Succesfully updated");

            
        }

        private void Update_Load(object sender, EventArgs e)
        {
            Methods m = new Methods();
            comboBox3.DataSource = m.ListCompany();
            comboBox3.DisplayMember = "CompanyName";
            comboBox3.ValueMember = "CompanyId";

            comboBox1.DataSource = m.ListUser();
            comboBox1.DisplayMember = "UserName";
            comboBox1.ValueMember = "UserId";

            comboBox2.DataSource = m.ListUser();
            comboBox2.DisplayMember = "UserName";
            comboBox2.ValueMember = "UserId";

            textBox1.Text = companyid.ToString();
            textBox2.Text = companyname;
            comboBox1.Text = userid.ToString();
            textBox4.Text = number.ToString();
            textBox5.Text = totalnumber.ToString();
            textBox3.Text = computerid.ToString();
            textBox8.Text = computerbrand;
            textBox7.Text = addnumber.ToString();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            textBox1.Text = companyid.ToString();
            textBox2.Text = companyname;
            comboBox1.Text = userid.ToString();
            textBox4.Text = number.ToString();
            textBox5.Text = totalnumber.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            textBox3.Text = computerid.ToString();
            textBox8.Text = computerbrand;
            textBox7.Text = addnumber.ToString();
            dateTimePicker1.Value = (DateTime)date;
            Methods m = new Methods();
            comboBox3.DataSource = m.ListCompany();
            comboBox3.DisplayMember = "CompanyName";
            comboBox3.ValueMember = "CompanyId";
            comboBox3.Text = companyname;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            m.UpdateComputer(Int32.Parse( textBox3.Text),
                textBox8.Text, Int32.Parse(textBox7.Text), 
                dateTimePicker1.Text,(int)comboBox3.SelectedValue, (int)comboBox2.SelectedValue);
            MessageBox.Show("Succesfully updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            this.Hide();
            m.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            m.UpdateUser(Int32.Parse( textBox6.Text),textBox10.Text,textBox9.Text,textBox11.Text);
            MessageBox.Show("Succesfully updated");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            textBox6.Text = userid.ToString();
            textBox10.Text = username;
            textBox9.Text = email;
            textBox11.Text = password;
            Methods m = new Methods();
            
        }
    }
}
