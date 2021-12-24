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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            Database db = new Database();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void HotelFunc(object sender, EventArgs e)
        {
            this.Hide();
            new HotelBook().Show();

        }

        private void Offerfuc(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void FlightFuc(object sender, EventArgs e)
        {
            this.Hide();
            new FlightBook().Show();

        }

        private void exit(object sender, EventArgs e)
        {

            this.Hide();
            new Form1().Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
