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
    
    public partial class MainForm : Form
    {
        Methods m = new Methods();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Methods m = new Methods();
            if (grdList.SelectedRows.Count > 0 && grdList.Columns.Contains("CompanyName"))
            {
                int index = grdList.SelectedRows[0].Index;
                int companyid = (int)grdList.Rows[index].Cells["CompanyId"].Value;
                m.DeleteFromCompany(companyid);
                grdList.DataSource = m.SelectCompany();
            }
            else if (grdComp.SelectedRows.Count > 0)
            {
                int index = grdComp.SelectedRows[0].Index;
                int computerid = (int)grdComp.Rows[index].Cells["ComputerId"].Value;
                m.DeleteFromComputer(computerid);
                grdComp.DataSource = m.SelectComputer();
            }
            else if (grdList.SelectedRows.Count > 0 && grdList.Columns.Contains("UserName"))
            {
                int index = grdList.SelectedRows[0].Index;
                int userid = (int)grdList.Rows[index].Cells["UserId"].Value;
                if (m.DeleteFromUser(userid) == "")
                {
                    MessageBox.Show("User deleted succesfully");
                }
                else { 
                    string error = m.DeleteFromUser(userid);
                    MessageBox.Show($"This user have created values in database \n{error}");
                }
                
                grdList.DataSource = m.SelectUsers();
            }
            else { MessageBox.Show("please select row"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grdList.SelectedRows.Count > 0 && grdList.Columns.Contains("CompanyId"))
            {
                int index = grdList.SelectedRows[0].Index;
                int companyid = (int)grdList.Rows[index].Cells["CompanyId"].Value;
                string companyname = (string)grdList.Rows[index].Cells["CompanyName"].Value;
                int userid = (int)grdList.Rows[index].Cells["UserId"].Value;
                int? number = (int?)grdList.Rows[index].Cells["Number"].Value;
                int? totalnumber = (int?)grdList.Rows[index].Cells["TotalNumber"].Value;
                Update u = new Update(companyid, companyname, userid, totalnumber, number,null, 
                    null, null, null, null, null,null,null,null,null);
                Methods m = new Methods();
                grdList.DataSource = m.SelectCompany();
                this.Hide(); u.ShowDialog();
            }
            else if (grdComp.SelectedRows.Count > 0)
            {
                int index = grdComp.SelectedRows[0].Index;
                int computerid = (int)grdComp.Rows[index].Cells["ComputerId"].Value;
                string computerbrand = (string)grdComp.Rows[index].Cells["ComputerBrand"].Value;
                int addnumber = (int)grdComp.Rows[index].Cells["Number1"].Value;
                DateTime date = (DateTime)grdComp.Rows[index].Cells["Date"].Value;
                int companyidf = (int)grdComp.Rows[index].Cells["CompanyId1"].Value;
                int userid = (int)grdComp.Rows[index].Cells["UserId1"].Value;
                Update u = new Update(null, null, null, null, null, computerid, computerbrand, addnumber, date, 
                    companyidf,userid,null,null,null,null);
                this.Hide();
                u.ShowDialog();
            }

            else if (grdList.SelectedRows.Count > 0 && grdList.Columns.Contains("UserName"))
            {
                int index = grdList.SelectedRows[0].Index;
                int useridu = (int)grdList.Rows[index].Cells["UserId"].Value;
                string username = (string)grdList.Rows[index].Cells["UserName"].Value;
                string email = (string)grdList.Rows[index].Cells["Email"].Value;
                string password = (string)grdList.Rows[index].Cells["Password"].Value;
                Update u = new Update(null, null, null, null, null, null, null, null, null,
                    null,null,useridu,username,email,password);
                this.Hide();
                u.ShowDialog();
            }

            else
            {
                MessageBox.Show("Please select row to update");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Add a = new Add();
            this.Hide();
            a.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Methods m = new Methods();
            m.UpdateTotalNumber();
            grdList.DataSource = m.SelectCompany();
            grdComp.DataSource = m.SelectComputer();
        }

        private void companyIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            grdList.DataSource= m.SortCompanyById();
        }

        private void companyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            grdList.DataSource = m.SortByName();
        }

        private void numberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            grdList.DataSource = m.SortByNumber();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            grdList.DataSource = m.SortByUser();
        }

        private void totalNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        int i = 0;
        void Setbtnenabling()
        {
            if(i>0)
            {
                companiesToolStripMenuItem.Enabled = false;
            }
            else { companiesToolStripMenuItem.Enabled = true; }
        }
        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grdList.DataSource = m.SelectUsers();
            i++;
            Setbtnenabling();
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.BackColor = Color.White;
            this.button1.ForeColor = Color.Orange;
            this.button2.ForeColor = Color.Orange;
            this.button3.ForeColor = Color.Orange;
            this.grdList.BackgroundColor = Color.White;
            this.grdComp.BackgroundColor = Color.White;
        }


        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(52, 58, 64);
            this.button1.ForeColor = Color.White;
            this.button2.ForeColor = Color.White;
            this.button3.ForeColor = Color.White;
            this.grdList.BackgroundColor = Color.FromArgb(52, 58, 64); ;
            this.grdComp.BackgroundColor = Color.FromArgb(52, 58, 64); ;

        }

        

        private void descendingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            grdComp.DataSource = m.SortByNumberComputerDesc();
        }

        private void saleDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            grdComp.DataSource=m.SortByNumberComputer();
        }
    }
}
