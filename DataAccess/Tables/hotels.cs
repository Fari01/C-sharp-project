using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess.Entities;

namespace DataAccess.Tables
{
  public  class hotels
    {

        SqlConnection conn;
        public hotels()
        {

            string connStr = @"Server=DESKTOP-M3S13RF\SQLEXPRESS;Database=ProjectWork;Integrated Security=true";
            conn = new SqlConnection(connStr);
        }//operations
        public List<hotel> GetAllHotels()
        {
            string query = "select * from Reserveh";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            //read
            SqlDataReader reader = cmd.ExecuteReader();
            //take database things as class object
            List<hotel> data = new List<hotel>(); //dynamic.Automatic kome jabe

            while (reader.Read())
            {

               hotel cus = new hotel();
              
                cus.Room = reader.GetString(reader.GetOrdinal("Room"));
                cus.Datein = reader.GetString(reader.GetOrdinal("Datein"));
                cus.Dateout = reader.GetString(reader.GetOrdinal("Dateout"));
                data.Add(cus); //insert hoye jabe array te

            }
            return data;
        }

        public bool Insert(hotel emp)
        {
            string query = String.Format("Insert into Reserveh values ('{0}','{1}','{2}')", emp.Room, emp.Datein, emp.Dateout);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) { return true; }
            else
            {
                return false;
            }
        }
        public bool Delete(string username)
        {//delete only username from search
            string query = String.Format("delete from Reserveh where Room='{0}'", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) { return true; }
            return false;
        }

        public hotel Search(string searching)
        {
            string query = String.Format("select * from Reserveh where Room='{0}'", searching);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            hotel a = null;
            while (reader.Read())
            {
                 a = new hotel();
              
                a.Room = reader.GetString(reader.GetOrdinal("Room"));
                a.Datein = reader.GetString(reader.GetOrdinal("Datein"));
                a.Dateout = reader.GetString(reader.GetOrdinal("Dateout"));



            }
            conn.Close();
            return a;


        }
    }
}
