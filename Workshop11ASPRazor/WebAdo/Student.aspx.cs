using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebAdo
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<centre><h1>Read data from a database</h1></cerntre>");
            Response.Write("<br/>");
            UpdateGrid();

        }

        public void UpdateGrid() {
            string s = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            SqlConnection con = new SqlConnection(s);
            string sqlString = "Select * From Student";
            SqlCommand cmd = new SqlCommand(sqlString, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<center><h1>Read data from a database</h1></center><hr/");
            Response.Write("<br/>");
            String txtValue = TextBox1.Text;
            int num; 
            bool isNumeric = int.TryParse(txtValue, out num);
            if (!isNumeric) { 
                return;
            }

            string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            string sqlString = "select * from Student where Age=@Age";
            SqlCommand cmd = new SqlCommand(sqlString, con);
            cmd.Parameters.AddWithValue("@Age", txtValue);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
            con.Close();
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            SqlCommand command;

            String txtAge = TextBoxAge.Text;
            int num;
            bool isNumeric = int.TryParse(txtAge, out num);
            if (!isNumeric)
            {
                return;
            }
            string query = string.Format("INSERT INTO Student (Name, Age) VALUES('{0}',{1})", TextBoxName.Text, num);
            command = new SqlCommand(query);
            command.Connection = con;
            con.Open();
            command.ExecuteNonQuery();
            command.Dispose();
            con.Close();
            UpdateGrid();

        }

        protected void ButtonDel_Click(object sender, EventArgs e)
        {
            string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            SqlCommand command;

            int num;
            bool isNumeric = int.TryParse(TextBoxId.Text, out num);
            if (!isNumeric)
            {
                return;
            }

            string query = string.Format("Delete from Student where(StudentID = {0})", num);
            command = new SqlCommand(query);
            command.Connection = con;
            con.Open();
            command.ExecuteNonQuery();
            command.Dispose();
            con.Close();
            UpdateGrid();

        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            SqlCommand command;

            int Id;
            bool isNumeric = int.TryParse(TextBoxUpdateId.Text, out Id);
            if (!isNumeric)
            {
                return;
            }

            int Age;
            isNumeric = int.TryParse(TextBoxUpdateAge.Text, out Age);
            if (!isNumeric)
            {
                return;
            }

            string query = string.Format("UPDATE Student SET Name='{0}', Age={1} where(StudentID = {2})", TextBoxUpdateName.Text, Age, Id);
            command = new SqlCommand(query);
            command.Connection = con;
            con.Open();
            command.ExecuteNonQuery();
            command.Dispose();
            con.Close();
            UpdateGrid();

        }



        protected int getNextId(string tableName)
        {
            string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection con = new SqlConnection(s);

            SqlCommand command;
            SqlDataReader dataReader;

            List<int> ids = new List<int>();

            string query = string.Format("Select {0}ID from {0}", tableName);

            command = new SqlCommand(query);
            command.Connection = con;

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ids.Add((int)dataReader.GetValue(0));
            }
            dataReader.Close();
            command.Dispose();

            if (!ids.Any())
            {
                return 0;
            }

            con.Close();

            return ids.Max();

        }
    }
}