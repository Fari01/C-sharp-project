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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Database db = new Database();
            dtEmployee.DataSource = db.features.GetAllOffers();

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit(); //kill background application
        }

        private void search_Click(object sender, EventArgs e)
        {
          
        }

        private void ClickUser(object sender, EventArgs e)
        {
            string searching = ttravel.Text;
            Database db = new Database();
            feature cus = db.features.Search(searching);
            if (cus == null)
            {
                MessageBox.Show("List not found");
                //ager val off kore dibe
                tpre.Text = "";
                tbudget.Text = "";
            }
            else
            {
                MessageBox.Show("Here you go");
                MessageBox.Show("You can customise this to your right!!");
                tpre.Text = cus.Preferences;
               tbudget.Text = cus.Budget;
               
            }
        }

       private void UpdateClick(object sender, EventArgs e)
        {    //store input
            string updatepreference = tpre.Text;
            string updatedbudget = tbudget.Text;
            feature emp = new feature();
            //call tables through employee obj
            emp.Offers = ttravel.Text;
            emp.Preferences = updatepreference;
            emp.Budget = updatedbudget;
            //db obj
            Database db = new Database();
            // update kore result return korbe
            bool rs = db.features.Update(emp);
            //check if updated
            if (rs)
            {
                dtEmployee.DataSource = db.features.GetAllOffers();
                MessageBox.Show("Updated");

            }
            else
            {
                MessageBox.Show("Failed to update");
            }


        }

        private void DeleteFunchtion(object sender, EventArgs e)
        {   //delet username from search box
            //so take input
            string username = ttravel.Text;
            Database db = new Database();
            bool rs = db.features.Delete(username);
            if (rs)
            {
                dtEmployee.DataSource = db.features.GetAllOffers();
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HomeFunction(object sender, EventArgs e)
        {
            this.Hide();
            new Homepage().Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dtEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
