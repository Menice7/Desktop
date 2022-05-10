using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopProject
{
    class Methods
    {
        #region CheckUser
        public bool SelectUser(string username, string password)
        {
            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = "select UserName,Password from User1";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sqldatareader = cmd.ExecuteReader();
            bool bl = true;
            while (sqldatareader.Read())
            {
                string a = sqldatareader.GetString(0).Replace(" ", "");
                string b = sqldatareader.GetString(1).Replace(" ", "");
                if (a == username && b == password)
                {
                    bl = true;
                    break;
                }
                else
                {
                    bl = false;
                }
                //return bl;
            }
            return bl;
        }
        #endregion

        #region InsertUser
        public void InsertUser(string username, string email, string password)
        {

            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = $"insert into User1(UserName,Email,Password) values('{username}', '{email}', '{password}')";
            SqlCommand cmd = new SqlCommand(query, con);
            int x = cmd.ExecuteNonQuery();

        }
        #endregion

        #region DeleteFromCompany
        public void DeleteFromCompany(int companyid)
        {
            string CONNECTIONSTRING = "Server=Localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            //int index = dataGridView1.SelectedRows[0].Index;
            //int filmid = (int)dataGridView1.Rows[index].Cells["FilmId"].Value;
            string delete = $"delete from ComputerCompanies where CompanyId={companyid}";
            SqlCommand cmd = new SqlCommand(delete, con);
            int x = cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region DeleteFromComputer
        public void DeleteFromComputer(int computerid)
        {
            string CONNECTIONSTRING = "Server=Localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            //int index = dataGridView1.SelectedRows[0].Index;
            //int filmid = (int)dataGridView1.Rows[index].Cells["FilmId"].Value;
            string delete = $"delete from Computer where ComputerId={computerid}";
            SqlCommand cmd = new SqlCommand(delete, con);
            int x = cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region DeleteFromUser
        
        public string DeleteFromUser(int userid)
        {
            try
            {
                string CONNECTIONSTRING = "Server=Localhost; Database=DesktopProject; Integrated Security=True";
                SqlConnection con = new SqlConnection(CONNECTIONSTRING);
                con.Open();
                //int index = dataGridView1.SelectedRows[0].Index;
                //int filmid = (int)dataGridView1.Rows[index].Cells["FilmId"].Value;
                string delete = $"delete from User1 where UserId={userid}";
                SqlCommand cmd = new SqlCommand(delete, con);
                int x = cmd.ExecuteNonQuery();
                con.Close();
                return "";
            }
            catch (Exception e)
            {
                return $"{e.Message}";
            }
        }
        
        #endregion

        #region AddCompany
        public void AddCompany(string companyname, int userid, int totalnumber, int number)
        {
            #region Add
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=Localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string add = $"insert into ComputerCompanies(CompanyName,UserId,TotalNumber,Number) " +
                $"values ('{companyname}','{userid}'," +
                $"{totalnumber},{number} )";
            SqlCommand cmd = new SqlCommand(add, con);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            #endregion
        }
        #endregion

        #region AddComputer
        public void AddComputer(string computerbrand, int number, string date, int companyid, int userid)
        {
            #region Add
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=Localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string add = $"insert into Computer(ComputerBrand,Number,Date,CompanyId,UserId) " +
                $"values ('{computerbrand}','{number}'," +
                $"{date},{companyid},{userid} )";
            SqlCommand cmd = new SqlCommand(add, con);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            #endregion
        }
        #endregion

        #region UpdateCompany
        public void UpdateCompany(int companyid, string companyname, int userid, int totalnumber, int number)
        {
            #region Update
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=Localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();

            string update = $"update ComputerCompanies set CompanyName='{companyname}', " +
                $"UserId={userid},TotalNumber={totalnumber+number},Number = {number}" +
                $" where CompanyId={companyid}";
            SqlCommand cmd = new SqlCommand(update, con);
            int x = cmd.ExecuteNonQuery();

            con.Close();
            #endregion
        }
        #endregion

        #region UpdateComputer
        public void UpdateComputer(int computerid, string brand, int number, string date, int companyid, int userid)
        {
            #region Update
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=Localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string update = $"update Computer set ComputerBrand='{brand}', " +
                $"Date='{date}',Number = {number},CompanyId={companyid},UserId={userid}" +
                $" where ComputerId={computerid}";
            SqlCommand cmd = new SqlCommand(update, con);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            #endregion
        }
        #endregion

        #region UpdateUser
        public void UpdateUser(int userid, string username, string email, string password)
        {
            #region Update
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=Localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();

            string update = $"update User1 set UserName='{username}', " +
                $"Email={email},Password= {password}" +
                $" where UserId={userid}";
            SqlCommand cmd = new SqlCommand(update, con);
            int x = cmd.ExecuteNonQuery();

            con.Close();
            #endregion
        }
        #endregion

        #region UpdateTotalNumber
        
        public void UpdateTotalNumber()
        {
            #region Update
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=Localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string update = $"UPDATE ComputerCompanies SET TotalNumber = (SELECT sum(c.Number) FROM Computer c, ComputerCompanies cc WHERE c.CompanyId = cc.CompanyId); ";
            SqlCommand cmd = new SqlCommand(update, con);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            #endregion
        }
        
        #endregion

        #region SelectCompany
        public DataTable SelectCompany()
        {

            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();

            DataTable dt = new DataTable();

            string query = "select * from ComputerCompanies";
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(query, con);
            sqldataadapter.Fill(dt);

            con.Close();
            return dt;
        }
        #endregion

        #region SelectComputer
        public DataTable SelectComputer()
        {
            DataTable dt = new DataTable();

            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = "select * from Computer";
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(query, con);
            sqldataadapter.Fill(dt);
            return dt;
        }
        #endregion

        #region SelectUser
        public DataTable SelectUsers()
        {
            DataTable dt = new DataTable();

            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = "select * from User1";
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(query, con);
            sqldataadapter.Fill(dt);
            return dt;
        }
        #endregion

        #region SortCompany
        public DataTable SortCompanyById()
        {
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = "select * from ComputerCompanies order by CompanyId";
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(query, con);
            sqldataadapter.Fill(dt);
            return dt;
        }
        #endregion

        #region SortByName
        public DataTable SortByName()
        {
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = "select * from ComputerCompanies order by CompanyName";
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(query, con);
            sqldataadapter.Fill(dt);
            return dt;
        }
        #endregion

        #region SortByNumber
        public DataTable SortByNumber()
        {
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = "select * from ComputerCompanies order by Number";
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(query, con);
            sqldataadapter.Fill(dt);
            return dt;
        }
        #endregion

        #region SortByNumberComputer
        public DataTable SortByNumberComputer()
        {
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = "select * from Computer order by Number";
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(query, con);
            sqldataadapter.Fill(dt);
            return dt;
        }
        #endregion

        #region SortByNumberComputerDesc
        public DataTable SortByNumberComputerDesc()
        {
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = "select * from Computer order by Number Desc";
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(query, con);
            sqldataadapter.Fill(dt);
            return dt;
        }
        #endregion

        #region SortByTotalNumber

        public DataTable SortByTotalNumber()
        {
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = "select * from ComputerCompanies order by TotalNumber";
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(query, con);
            sqldataadapter.Fill(dt);
            return dt;
        }
        
        #endregion

        #region SortByUser
        public DataTable SortByUser()
        {
            DataTable dt = new DataTable();
            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = "select * from ComputerCompanies order by UserId";
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(query, con);
            sqldataadapter.Fill(dt);
            return dt;
        }
        #endregion

        #region combodata
        public List<Company> ListCompany()
        {
            List<Company> company = new List<Company>();
            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = @"select CompanyId,CompanyName from ComputerCompanies";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sqldatareader = cmd.ExecuteReader();
            while (sqldatareader.Read())
            {
                company.Add(new Company()
                {
                    CompanyId = sqldatareader.GetInt32(0),
                    CompanyName = sqldatareader.GetString(1)
                });
            }
            return company;

        }

        public List<User> ListUser()
        {
            List<User> users = new List<User>();
            string CONNECTIONSTRING = "Server=localhost; Database=DesktopProject; Integrated Security=True";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            con.Open();
            string query = @"select UserId,UserName from User1";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sqldatareader = cmd.ExecuteReader();
            while (sqldatareader.Read())
            {
                users.Add(new User()
                {
                    UserId = sqldatareader.GetInt32(0),
                    UserName = sqldatareader.GetString(1)
                });
            }
            return users;

        }
        #endregion

        #region 
        #endregion
    }
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}

