namespace LibrarySystem
{
    partial class DashboardForm
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
            btnBooks = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.LightBlue;
            btnBooks.ForeColor = SystemColors.Highlight;
            btnBooks.Location = new Point(12, 27);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(173, 66);
            btnBooks.TabIndex = 0;
            btnBooks.Text = "Manage Books";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.LightBlue;
            btnReports.ForeColor = SystemColors.Highlight;
            btnReports.Location = new Point(12, 117);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(173, 66);
            btnReports.TabIndex = 0;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightBlue;
            btnLogout.ForeColor = SystemColors.Highlight;
            btnLogout.Location = new Point(12, 207);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(173, 66);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightBlue;
            btnExit.ForeColor = SystemColors.Highlight;
            btnExit.Location = new Point(12, 300);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(173, 66);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(440, 470);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(btnBooks);
            ForeColor = SystemColors.ControlLight;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion
        private Button btnBooks;
        private Button btnReports;
        private Button btnLogout;
        private Button btnExit;
    }
}