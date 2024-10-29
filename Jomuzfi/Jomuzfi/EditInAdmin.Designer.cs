namespace Jomuzfi
{
    partial class EditInAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.TextBox();
            this.likes = new System.Windows.Forms.TextBox();
            this.trailer = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TitleC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenreC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LikesC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrailerC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(314, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit a movie in the Movielist";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(564, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Year";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(568, 120);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(356, 22);
            this.title.TabIndex = 15;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(568, 175);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(356, 22);
            this.year.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Likes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Trailer";
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(568, 236);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(356, 22);
            this.genre.TabIndex = 20;
            // 
            // likes
            // 
            this.likes.Location = new System.Drawing.Point(568, 290);
            this.likes.Name = "likes";
            this.likes.Size = new System.Drawing.Size(356, 22);
            this.likes.TabIndex = 21;
            // 
            // trailer
            // 
            this.trailer.Location = new System.Drawing.Point(568, 348);
            this.trailer.Name = "trailer";
            this.trailer.Size = new System.Drawing.Size(356, 22);
            this.trailer.TabIndex = 22;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TitleC,
            this.YearC,
            this.GenreC,
            this.LikesC,
            this.TrailerC});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(491, 321);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView1_ItemSelectionChanged);
            // 
            // TitleC
            // 
            this.TitleC.Text = "Title";
            this.TitleC.Width = 300;
            // 
            // YearC
            // 
            this.YearC.Text = "Year";
            this.YearC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YearC.Width = 130;
            // 
            // GenreC
            // 
            this.GenreC.Text = "Genre";
            this.GenreC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GenreC.Width = 130;
            // 
            // LikesC
            // 
            this.LikesC.Text = "Likes";
            this.LikesC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LikesC.Width = 100;
            // 
            // TrailerC
            // 
            this.TrailerC.Text = "Trailer";
            this.TrailerC.Width = 600;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(46, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 43);
            this.button2.TabIndex = 24;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(808, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 25;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EditInAdmin
            // 
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(956, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.trailer);
            this.Controls.Add(this.likes);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.year);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditInAdmin";
            this.Text = "EditInAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditInAdmin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.TextBox likes;
        private System.Windows.Forms.TextBox trailer;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TitleC;
        private System.Windows.Forms.ColumnHeader YearC;
        private System.Windows.Forms.ColumnHeader GenreC;
        private System.Windows.Forms.ColumnHeader LikesC;
        private System.Windows.Forms.ColumnHeader TrailerC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
