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
            DataTable dt = DatabaseHelper.GetData("SELECT * FROM Books");

            int total = dt.Rows.Count;
            int science = dt.Select("Category = 'Science'").Length;
            int novel = dt.Select("Category = 'Novel'").Length;
            int history = dt.Select("Category = 'History'").Length;
            int technology = dt.Select("Category = 'Technology'").Length;
            int kids = dt.Select("Category = 'Kids'").Length;

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
