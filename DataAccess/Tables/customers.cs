using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess.Entities;


namespace DataAccess.Tables
{
    public class customers
    {

        SqlConnection conn;
        public customers()
        {

            string connStr = @"Server=DESKTOP-M3S13RF\SQLEXPRESS;Database=ProjectWork;Integrated Security=true";
            conn = new SqlConnection(connStr);
        }//operations
        public List<customer> GetAllCustomers()
        {
            string query = "select * from customer_info";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);//send to db
            //read                    //return data
            SqlDataReader reader = cmd.ExecuteReader();
            //take database things as class object
            List<customer> data = new List<customer>(); //dynamic.Automatic kome jabe

            while (reader.Read())
            {

                customer emp = new customer();
                emp.First_name = reader.GetString(reader.GetOrdinal("First_name"));
                emp.Last_name = reader.GetString(reader.GetOrdinal("Last_name"));
                emp.Email = reader.GetString(reader.GetOrdinal("Email"));
                emp.Username = reader.GetString(reader.GetOrdinal("Username"));
                emp.Password = reader.GetString(reader.GetOrdinal("Password"));
                data.Add(emp); //insert hoye jabe array te

            }
            return data;
        }

       

        //new
        public bool CheckLogin(string username, string password)
        {
            string query = String.Format("select Username  from customer_info where Username='{0}' and Password='{1}'", username, password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
            return false;

        }
        



        public customer GetEmployee(string Username) // return single employee
        {
            string query = "select * from customer_info where Username =" + Username;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            customer emp = null;
            while (reader.Read())
            {
               
                emp = new customer();
                emp.First_name = reader.GetString(reader.GetOrdinal("Fist_name"));
                emp.Last_name = reader.GetString(reader.GetOrdinal("Last_name"));
                emp.Email = reader.GetString(reader.GetOrdinal("Email"));
                emp.Username = reader.GetString(reader.GetOrdinal("Username"));
                emp.Password = reader.GetString(reader.GetOrdinal("Password"));
                    }
            conn.Close();
            return emp;
        }

        public bool Insert(customer emp)
        {
            string query = String.Format("Insert into customer_info values ('{0}','{1}','{2}','{3}',{4})", emp.First_name, emp.Last_name, emp.Email, emp.Username, emp.Password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();//change data in db
            conn.Close();
            if (r > 0) { return true; }
            else
            {
                return false;
            }
        }
        public bool Update(customer emp)
        {
            string query = String.Format("Update customer_info set First_name='{0}', Last_name='{1}' , Email='{2}' where Username='{3}'", emp.First_name, emp.Last_name, emp.Email, emp.Username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool Delete(string username)
        {//delet only username from search
            string query = String.Format("delete from customer_info where Username='{0}'", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) { return true; }
            return false;
        }

        public customer Search(string uname)
        {
            string query = String.Format("select * from travel where Offers='{0}'", uname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            customer emp = null;
            while (reader.Read())
            {
                emp = new customer();
                emp.First_name = reader.GetString(reader.GetOrdinal("Offers"));
                emp.Last_name = reader.GetString(reader.GetOrdinal("Preferences"));
                emp.Email = reader.GetString(reader.GetOrdinal("Budget"));
              
            
                
            }
            conn.Close();
            return emp;

        }









    }
}
    
