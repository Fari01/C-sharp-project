using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Tables; //add
using System.Data.SqlClient;//add
using DataAccess.Entities;
using DataAccess;

namespace DataAccess
{
    public class Database
    {


        //keep objects here of tables
        public hotels apple{ get; set; }
        public flights Feature { get; set; }
        public customers Features { get; set; }
        public features features { get; set; }
        public Database() {
            /*string connStr = @"Server=DESKTOP-M3S13RF\SQLEXPRESS;Database=Library_DB;Integrated Security=true=";
            SqlConnection conn = new SqlConnection(connStr);
            Books = new Books(conn); */
            apple = new hotels();
            Feature = new flights();
            Features = new customers();
            features = new features();
            
        }
       
        



    }
}
