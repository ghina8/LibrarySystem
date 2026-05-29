using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int total = DataStore.Books.Count;
            int science = DataStore.Books.Count(b => b.Category.ToLower() == "science");
            int novel = DataStore.Books.Count(b => b.Category.ToLower() == "novel");
            int history = DataStore.Books.Count(b => b.Category.ToLower() == "history");
            int technology = DataStore.Books.Count(b => b.Category.ToLower() == "technology");
            int kids = DataStore.Books.Count(b => b.Category.ToLower() == "kids");

            lblTotal.Text = "Total Books: " + total;
            lblScience.Text = "Science Books: " + science;
            lblNovel.Text = "Novel Books: " + novel;
            lblHistory.Text = "History Books: " + history;
            lblTechnology.Text = "Technology Books: " + technology;
            lblKids.Text = "Kids Books: " + kids;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblScience_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblNovel_Click(object sender, EventArgs e)
        {

        }
    }
}
