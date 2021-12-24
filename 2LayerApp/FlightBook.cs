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
    public partial class FlightBook : Form
    {
        public FlightBook()
        {
            InitializeComponent();
           
            Database db = new Database();
            dtEmp.DataSource = db.Feature.GetAllFlight();
        }

        public void InsertFunc(object sender, EventArgs e)
        {
            var Code = CodeBox.Text;
            var Destination = DestinationBox.Text;
            var source = SourceBox.Text;
            var takeoff =Datebox.Text;
         
            flight emp = new flight();
            emp.Code = Code;
            emp.Destination = Destination;
            emp.Source = source;
            emp.TakeoffDate =takeoff;
           
            Database db = new Database();
            var r = db.Feature.Insert(emp);//call insert func

            if (r)
            {
                MessageBox.Show("Booked");
                dtEmp.DataSource = db.Feature.GetAllFlight();
            }
            else
            {
                MessageBox.Show("Error occured");
            }

            


        }

        private void searchfuc(object sender, EventArgs e)
        {
            string searching = searchbox.Text;
            Database db = new Database();
            flight cus = db.Feature.Search(searching);
            if (cus == null)
            {
                MessageBox.Show("List not found");
                //ager val off kore dibe
                CodeBox.Text = "";
                DestinationBox.Text = "";
                SourceBox.Text = "";
                Datebox.Text = "";
            }
            else
            {
                MessageBox.Show("Here you go");
                CodeBox.Text = cus.Code;
                DestinationBox.Text = cus.Destination;
                SourceBox.Text = cus.Source;
                Datebox.Text =cus.TakeoffDate;

            }
        }


        private void DeleteFunc(object sender, EventArgs e)
        {
            //delet username from search box
            //so take input
            string username = CodeBox.Text;
            Database db = new Database();
            bool rs = db.Feature.Delete(username);
            if (rs==true)
            {
                dtEmp.DataSource = db.Feature.GetAllFlight();
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Reet(object sender, EventArgs e)
        {
            CodeBox.Text = string.Empty;
            DestinationBox.Text = string.Empty;
            SourceBox.Text = string.Empty;
            Datebox.Text = string.Empty;

        }

        private void click(object sender, EventArgs e)
        {
            this.Hide();
            new Homepage().Show();
        }
    }
}
