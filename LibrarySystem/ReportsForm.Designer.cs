namespace LibrarySystem
{
    partial class ReportsForm
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
            lblTotal = new Label();
            lblScience = new Label();
            lblNovel = new Label();
            btnShow = new Button();
            btnBack = new Button();
            lblHistory = new Label();
            lblTechnology = new Label();
            lblKids = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Statistical Reports";
            label1.Click += label1_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = SystemColors.HotTrack;
            lblTotal.Location = new Point(12, 99);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(101, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total Books: 0";
            // 
            // lblScience
            // 
            lblScience.AutoSize = true;
            lblScience.ForeColor = SystemColors.HotTrack;
            lblScience.Location = new Point(12, 151);
            lblScience.Name = "lblScience";
            lblScience.Size = new Size(118, 20);
            lblScience.TabIndex = 0;
            lblScience.Text = "Science Books: 0";
            lblScience.Click += lblScience_Click;
            // 
            // lblNovel
            // 
            lblNovel.AutoSize = true;
            lblNovel.ForeColor = SystemColors.HotTrack;
            lblNovel.Location = new Point(12, 201);
            lblNovel.Name = "lblNovel";
            lblNovel.Size = new Size(107, 20);
            lblNovel.TabIndex = 0;
            lblNovel.Text = "Novel Books: 0";
            lblNovel.Click += lblNovel_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.LightBlue;
            btnShow.ForeColor = SystemColors.Highlight;
            btnShow.Location = new Point(472, 349);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(127, 37);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show Reports";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightBlue;
            btnBack.ForeColor = SystemColors.Highlight;
            btnBack.Location = new Point(472, 395);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 37);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.ForeColor = SystemColors.HotTrack;
            lblHistory.Location = new Point(12, 249);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(115, 20);
            lblHistory.TabIndex = 0;
            lblHistory.Text = "History Books: 0";
            // 
            // lblTechnology
            // 
            lblTechnology.AutoSize = true;
            lblTechnology.ForeColor = SystemColors.HotTrack;
            lblTechnology.Location = new Point(12, 300);
            lblTechnology.Name = "lblTechnology";
            lblTechnology.Size = new Size(144, 20);
            lblTechnology.TabIndex = 0;
            lblTechnology.Text = "Technology Books: 0";
            // 
            // lblKids
            // 
            lblKids.AutoSize = true;
            lblKids.ForeColor = SystemColors.HotTrack;
            lblKids.Location = new Point(12, 349);
            lblKids.Name = "lblKids";
            lblKids.Size = new Size(96, 20);
            lblKids.TabIndex = 0;
            lblKids.Text = "Kids Books: 0";
            lblKids.Click += label4_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(611, 444);
            Controls.Add(btnBack);
            Controls.Add(btnShow);
            Controls.Add(lblKids);
            Controls.Add(lblTechnology);
            Controls.Add(lblHistory);
            Controls.Add(lblNovel);
            Controls.Add(lblScience);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Name = "ReportsForm";
            Text = "ReportsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTotal;
        private Label lblScience;
        private Label lblNovel;
        private Button btnShow;
        private Button btnBack;
        private Label lblHistory;
        private Label lblTechnology;
        private Label lblKids;
    }
}