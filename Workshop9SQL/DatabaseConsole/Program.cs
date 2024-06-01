using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DatabaseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SqlConnection cnn;


            string connString = "Data Source=WINDOWS-2H10582; Initial Catalog=Northwind;User ID=Tom;Password=password";
            cnn = new SqlConnection(connString);
            cnn.Open();
            Console.WriteLine("Connection is Open");

            dropHouse(cnn);

            createHouse(cnn);
            int next = getNextId(cnn, "house");
            Console.WriteLine(next);

            selectStudents(cnn);


            //Console.WriteLine("------------------");
            //addStudent(cnn, "tom2", 24);
            //selectStudents(cnn);

            Console.WriteLine("------------------");
            deleteStudent(cnn, getNextId(cnn, "Student"));
            selectStudents(cnn);

            Console.WriteLine("------------------");
            updateStudent(cnn, "Sheila", 44, getNextId(cnn, "Student"));
            selectStudents(cnn);

            cnn.Close();
        }

        static int getNextId(SqlConnection cnn, string tableName) {

            SqlCommand command;
            SqlDataReader dataReader;
            String output;

            List<int> ids = new List<int>();

            string query = string.Format("Select {0}ID from {0}", tableName);

            command = new SqlCommand(query);
            command.Connection = cnn;

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ids.Add((int)dataReader.GetValue(0));
            }
            dataReader.Close();
            command.Dispose();

            if (!ids.Any()) {
                return 0;
            }

            return ids.Max();


        }

        static void createHouse(SqlConnection cnn) {
            SqlCommand command;
            string query = "CREATE TABLE house ( houseID INT PRIMARY KEY, addLine1 VARCHAR(50), addLine2 VARCHAR(50), postcode VARCHAR(6))";
            command = new SqlCommand(query);
            command.Connection = cnn;
            command.ExecuteNonQuery();
            command.Dispose();
        }

        static void dropHouse(SqlConnection cnn)
        {
            SqlCommand command;
            string query = "DROP TABLE house";
            command = new SqlCommand(query);
            command.Connection = cnn;
            command.ExecuteNonQuery();
            command.Dispose();
        }

        static void selectStudents(SqlConnection cnn) {
            SqlCommand command;
            SqlDataReader dataReader;
            String output;

            string query = "Select Name, Age from Student";

            command = new SqlCommand(query);
            command.Connection = cnn;

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output = (String)dataReader.GetValue(0) + ", " + dataReader.GetValue(1);
                Console.WriteLine(output);
            }
            dataReader.Close();
            command.Dispose();
        }


        static void addStudent(SqlConnection cnn, string Name, int Age) {

            SqlCommand command;
            string query = string.Format("INSERT INTO Student (Name, Age) VALUES('{0}',{1})", Name, Age);
            command = new SqlCommand(query);
            command.Connection = cnn;
            command.ExecuteNonQuery();
            command.Dispose();
        }

        static void deleteStudent(SqlConnection cnn, int id) {
            SqlCommand command;
            string query = string.Format("Delete from Student where(StudentID = {0})", id);
            command = new SqlCommand(query);
            command.Connection = cnn;
            command.ExecuteNonQuery();
            command.Dispose();

        }

        static void updateStudent(SqlConnection cnn, string name, int age, int id)
        {
            SqlCommand command;
            string query = string.Format("UPDATE Student SET Name='{0}', Age={1} where(StudentID = {2})",name, age, id);
            command = new SqlCommand(query);
            command.Connection = cnn;
            command.ExecuteNonQuery();
            command.Dispose();

        }

    }
}
