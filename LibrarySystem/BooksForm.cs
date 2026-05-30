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
            if (txtId.Text == "" || txtTitle.Text == "" || txtAuthor.Text == "" || txtCategory.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            Book b = new Book();
            b.Id = int.Parse(txtId.Text);
            b.Title = txtTitle.Text;
            b.Author = txtAuthor.Text;
            b.Category = txtCategory.Text;

            DataStore.Books.Add(b);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataStore.Books;

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
                Book selectedBook = (Book)dataGridView1.CurrentRow.DataBoundItem;
                DataStore.Books.Remove(selectedBook);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataStore.Books;

            }
            MessageBox.Show("Book deleted successfully");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = DataStore.Books
                .Where(x => x.Title.ToLower().Contains(txtSearch.Text))
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result;
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

            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("ID must be a number");
                return;
            }

            if (dataGridView1.CurrentRow != null)
            {
                Book b = (Book)dataGridView1.CurrentRow.DataBoundItem;

                b.Id = id;
                b.Title = txtTitle.Text;
                b.Author = txtAuthor.Text;
                b.Category = txtCategory.Text;

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataStore.Books;

                MessageBox.Show("Book updated successfully");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataStore.Books;
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
