using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Entities;
using DataAccess.Tables;
using DataAccess;

namespace _2LayerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Database db = new Database();
            List<customer> data = db.Features.GetAllCustomers();
        
          

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit(); //kill background application
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //clickevent 
        private void LoginClick(object sender, EventArgs e)
        {
            string uname= Unamebox.Text;
            string pass = Upassbox.Text;
           //pop up window
            
            Database db = new Database();
            bool rs = db.Features.CheckLogin(uname, pass);
            MessageBox.Show("Welcome! Plan your dream vacation today");
            if(rs==true)
            {
                this.Hide();
                new Dashboard().Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and password");

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openregisterform(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Unamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }
    }
}
