using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
            LoadBooks();
        }
        private void LoadBooks()
        {
            dataGridView1.DataSource = DatabaseHelper.GetData("SELECT * FROM Books");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtAuthor.Text == "" || txtCategory.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            string query = $"INSERT INTO Books (Title, Author, Category) " +
               $"VALUES ('{txtTitle.Text}', '{txtAuthor.Text}', '{txtCategory.Text}')";

            DatabaseHelper.ExecuteQuery(query);

            LoadBooks();

            MessageBox.Show("Book added successfully");

            txtId.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtCategory.Clear();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                string query = $"DELETE FROM Books WHERE Id = {id}";
                DatabaseHelper.ExecuteQuery(query);

                LoadBooks();

                MessageBox.Show("Book deleted successfully");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Books WHERE Title LIKE '%{txtSearch.Text}%'";
            dataGridView1.DataSource = DatabaseHelper.GetData(query);
        }

        private void dataGridView1_CellContent(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Book b = (Book)dataGridView1.CurrentRow.DataBoundItem;

                txtId.Text = b.Id.ToString();
                txtTitle.Text = b.Title;
                txtAuthor.Text = b.Author;
                txtCategory.Text = b.Category;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtTitle.Text == "" || txtAuthor.Text == "" || txtCategory.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            string query = $"UPDATE Books SET " +
                           $"Title='{txtTitle.Text}', " +
                           $"Author='{txtAuthor.Text}', " +
                           $"Category='{txtCategory.Text}' " +
                           $"WHERE Id={txtId.Text}";

            DatabaseHelper.ExecuteQuery(query);

            LoadBooks();

            MessageBox.Show("Book updated successfully");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtCategory.Clear();
            txtSearch.Clear();
        }
    }
}
