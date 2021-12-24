using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess.Entities;

namespace DataAccess.Tables
{
   public class flights

    {

        SqlConnection conn;
        public flights()
        {

            string connStr = @"Server=DESKTOP-M3S13RF\SQLEXPRESS;Database=ProjectWork;Integrated Security=true";
            conn = new SqlConnection(connStr);
        }//operations
        public List<flight> GetAllFlight()
        {
            string query = "select * from ReservationF";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            //read
            SqlDataReader reader = cmd.ExecuteReader();
            //take database things as class object
            List<flight> data = new List<flight>(); //dynamic.Automatic kome jabe

            while (reader.Read())
            {

                flight cus = new flight();
                cus.Code = reader.GetString(reader.GetOrdinal("Code"));
                cus.Destination = reader.GetString(reader.GetOrdinal("Destination"));
                cus.Source= reader.GetString(reader.GetOrdinal("Source"));
                cus.TakeoffDate = reader.GetString(reader.GetOrdinal("TakeoffDate"));
                data.Add(cus); //insert hoye jabe array te

            }
            return data;
        }

       

        public bool Insert(flight emp)
        {
            string query = String.Format("Insert into ReservationF values ('{0}','{1}','{2}','{3}')", emp.Code, emp.Destination, emp.Source, emp.TakeoffDate);
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
            string query = String.Format("delete from ReservationF where Code='{0}'", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) { return true; }
            return false;
        }

        public flight Search(string searching)
        {
            string query = String.Format("select * from ReservationF where Code='{0}'", searching);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            flight a = new flight();
            while (reader.Read())
            {
                
                a.Code = reader.GetString(reader.GetOrdinal("Code"));
                a.Destination = reader.GetString(reader.GetOrdinal("Destination"));
                a.Source = reader.GetString(reader.GetOrdinal("Source"));
                a.TakeoffDate = reader.GetString(reader.GetOrdinal("TakeoffDate"));



            }
            conn.Close();
            return a;


        }
    }
}
