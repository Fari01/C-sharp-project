using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DataAccess.Entities;
namespace _2LayerApp
{
    public partial class HotelBook : Form
    {
        public HotelBook()
        {
            InitializeComponent();

            Database db = new Database();
            dtHotel.DataSource = db.apple.GetAllHotels();
        }

        private void DeleteFunc(object sender, EventArgs e)
        {

            //delet username from search box
            //so take input
            string username = RoomBox.Text;
            Database db = new Database();
            bool rs = db.apple.Delete(username);
            if (rs == true)
            {
                dtHotel.DataSource = db.apple.GetAllHotels();
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }

        }

        private void BookFunc(object sender, EventArgs e)
        {
            var room= RoomBox.Text;
            var din = DateinBox.Text;
            var dout = DateoutBox.Text;
         

            hotel emp = new hotel();
            emp.Datein = din;
            emp.Dateout = dout;
            emp.Room = room;
          

            Database db = new Database();
            var r = db.apple.Insert(emp);//call insert func

            if (r)
            {
                
                MessageBox.Show("Booked");
                dtHotel.DataSource = db.apple.GetAllHotels();
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }

        private void SearchFunc(object sender, EventArgs e)
        {
            string searching = search.Text;
            Database db = new Database();
            hotel gerry = db.apple.Search(searching);
            if (gerry == null)
            {
                MessageBox.Show("List not found");
                //ager val off kore dibe
                RoomBox.Text = "";
                DateinBox.Text = "";
                DateoutBox.Text = "";
               
            }
            else
            {
                MessageBox.Show("Here you go");
                dtHotel.DataSource = db.apple.GetAllHotels();
                RoomBox.Text =gerry.Room;
                DateinBox.Text =gerry.Datein;
                DateoutBox.Text =gerry.Dateout;
            }

        }

        private void reset(object sender, EventArgs e)
        {
            RoomBox.Text = string.Empty;
            DateinBox.Text = string.Empty;
            DateoutBox.Text = string.Empty;
           
        }

        private void exit(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void homie(object sender, EventArgs e)
        {
            this.Hide();
            new Homepage().Show();
        }
    }
}
