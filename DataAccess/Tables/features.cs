using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess.Entities;

namespace DataAccess.Tables
{
 public   class features
    {

        SqlConnection conn;
        public features()
        {

            string connStr = @"Server=DESKTOP-M3S13RF\SQLEXPRESS;Database=ProjectWork;Integrated Security=true";
            conn = new SqlConnection(connStr);
        }//operations
        public List<feature> GetAllOffers()
        {
            string query = "select * from travel";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            //read
            SqlDataReader reader = cmd.ExecuteReader();
            //take database things as class object
            List<feature> data = new List<feature>(); //dynamic.Automatic kome jabe

            while (reader.Read())
            {

                feature cus = new feature();
                cus.Offers = reader.GetString(reader.GetOrdinal("Offers"));
                cus.Preferences= reader.GetString(reader.GetOrdinal("Preferences"));
                cus.Budget = reader.GetString(reader.GetOrdinal("Budget"));
                data.Add(cus); //insert hoye jabe array te

            }
            return data;
        }
        public bool Update(feature emp)
        {
            string query = String.Format("Update travel set Offers='{0}', Preferences='{1}' , Budget='{2}' where Offers='{0}'", emp.Offers, emp.Preferences, emp.Budget);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool Delete(string username)
        {//delete only username from search
            string query = String.Format("delete from travel where Offers='{0}'", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) { return true; }
            return false;
        }

        public feature Search(string searching)
        {
            string query = String.Format("select * from travel where Offers='{0}'", searching);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            feature cus = null;
            while (reader.Read())
            {
                cus = new feature();
                cus.Offers = reader.GetString(reader.GetOrdinal("Offers"));
                cus.Preferences = reader.GetString(reader.GetOrdinal("Preferences"));
                cus.Budget = reader.GetString(reader.GetOrdinal("Budget"));



            }
            conn.Close();
            return cus;

        }
    }
}

























