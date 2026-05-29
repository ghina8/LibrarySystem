namespace LibrarySystem
{
    partial class BooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            txtAuthor = new TextBox();
            label4 = new Label();
            txtCategory = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            btnShowAll = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Book Id";
            // 
            // txtId
            // 
            txtId.BackColor = Color.AliceBlue;
            txtId.Location = new Point(111, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(198, 27);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(24, 89);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 0;
            label2.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.AliceBlue;
            txtTitle.Location = new Point(111, 86);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(198, 27);
            txtTitle.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(24, 141);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 0;
            label3.Text = "Author";
            label3.Click += label3_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.AliceBlue;
            txtAuthor.Location = new Point(111, 138);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(198, 27);
            txtAuthor.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(24, 202);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 0;
            label4.Text = "Category";
            label4.Click += label3_Click;
            // 
            // txtCategory
            // 
            txtCategory.BackColor = Color.AliceBlue;
            txtCategory.Location = new Point(111, 195);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(198, 27);
            txtCategory.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightBlue;
            btnAdd.ForeColor = SystemColors.Highlight;
            btnAdd.Location = new Point(351, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 41);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightBlue;
            btnDelete.ForeColor = SystemColors.Highlight;
            btnDelete.Location = new Point(351, 86);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 41);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 344);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 267);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContent;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.AliceBlue;
            txtSearch.Location = new Point(513, 37);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(159, 46);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightBlue;
            btnSearch.ForeColor = SystemColors.Highlight;
            btnSearch.Location = new Point(678, 42);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(134, 41);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightBlue;
            btnUpdate.ForeColor = SystemColors.Highlight;
            btnUpdate.Location = new Point(678, 104);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 37);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightBlue;
            btnBack.ForeColor = SystemColors.Highlight;
            btnBack.Location = new Point(351, 141);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(134, 39);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.LightBlue;
            btnShowAll.ForeColor = SystemColors.Highlight;
            btnShowAll.Location = new Point(538, 298);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(134, 40);
            btnShowAll.TabIndex = 8;
            btnShowAll.Text = "ShowAll";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightBlue;
            btnClear.ForeColor = SystemColors.Highlight;
            btnClear.Location = new Point(678, 299);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(134, 39);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(835, 623);
            Controls.Add(btnClear);
            Controls.Add(btnShowAll);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtCategory);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BooksForm";
            Text = "BooksForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtTitle;
        private Label label3;
        private TextBox txtAuthor;
        private Label label4;
        private TextBox txtCategory;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnUpdate;
        private Button btnBack;
        private Button btnShowAll;
        private Button btnClear;
    }
}