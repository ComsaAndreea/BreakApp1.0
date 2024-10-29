namespace Jomuzfi
{
    partial class UserForm
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
            this.AddWButton = new System.Windows.Forms.Button();
            this.DeleteWButton = new System.Windows.Forms.Button();
            this.WatchlistButton = new System.Windows.Forms.Button();
            this.MovielistUButton = new System.Windows.Forms.Button();
            this.BackUButton = new System.Windows.Forms.Button();
            this.ExitUButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddWButton
            // 
            this.AddWButton.BackColor = System.Drawing.Color.Coral;
            this.AddWButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.AddWButton.Location = new System.Drawing.Point(95, 130);
            this.AddWButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddWButton.Name = "AddWButton";
            this.AddWButton.Size = new System.Drawing.Size(132, 42);
            this.AddWButton.TabIndex = 0;
            this.AddWButton.Text = "Add";
            this.AddWButton.UseVisualStyleBackColor = false;
            this.AddWButton.Click += new System.EventHandler(this.AddWButton_Click);
            // 
            // DeleteWButton
            // 
            this.DeleteWButton.BackColor = System.Drawing.Color.Coral;
            this.DeleteWButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.DeleteWButton.Location = new System.Drawing.Point(95, 225);
            this.DeleteWButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteWButton.Name = "DeleteWButton";
            this.DeleteWButton.Size = new System.Drawing.Size(132, 48);
            this.DeleteWButton.TabIndex = 1;
            this.DeleteWButton.Text = "Delete";
            this.DeleteWButton.UseVisualStyleBackColor = false;
            this.DeleteWButton.Click += new System.EventHandler(this.DeleteWButton_Click);
            // 
            // WatchlistButton
            // 
            this.WatchlistButton.BackColor = System.Drawing.Color.Coral;
            this.WatchlistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.WatchlistButton.Location = new System.Drawing.Point(345, 225);
            this.WatchlistButton.Margin = new System.Windows.Forms.Padding(4);
            this.WatchlistButton.Name = "WatchlistButton";
            this.WatchlistButton.Size = new System.Drawing.Size(132, 48);
            this.WatchlistButton.TabIndex = 2;
            this.WatchlistButton.Text = "Watchlist";
            this.WatchlistButton.UseVisualStyleBackColor = false;
            this.WatchlistButton.Click += new System.EventHandler(this.WatchlistButton_Click);
            // 
            // MovielistUButton
            // 
            this.MovielistUButton.BackColor = System.Drawing.Color.Coral;
            this.MovielistUButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.MovielistUButton.Location = new System.Drawing.Point(345, 130);
            this.MovielistUButton.Margin = new System.Windows.Forms.Padding(4);
            this.MovielistUButton.Name = "MovielistUButton";
            this.MovielistUButton.Size = new System.Drawing.Size(132, 42);
            this.MovielistUButton.TabIndex = 3;
            this.MovielistUButton.Text = "Movielist";
            this.MovielistUButton.UseVisualStyleBackColor = false;
            this.MovielistUButton.Click += new System.EventHandler(this.MovielistButton_Click);
            // 
            // BackUButton
            // 
            this.BackUButton.BackColor = System.Drawing.Color.Khaki;
            this.BackUButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BackUButton.Location = new System.Drawing.Point(82, 397);
            this.BackUButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackUButton.Name = "BackUButton";
            this.BackUButton.Size = new System.Drawing.Size(132, 48);
            this.BackUButton.TabIndex = 4;
            this.BackUButton.Text = "Back";
            this.BackUButton.UseVisualStyleBackColor = false;
            this.BackUButton.Click += new System.EventHandler(this.BackUButton_Click);
            // 
            // ExitUButton
            // 
            this.ExitUButton.BackColor = System.Drawing.Color.Khaki;
            this.ExitUButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ExitUButton.Location = new System.Drawing.Point(633, 398);
            this.ExitUButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitUButton.Name = "ExitUButton";
            this.ExitUButton.Size = new System.Drawing.Size(132, 47);
            this.ExitUButton.TabIndex = 5;
            this.ExitUButton.Text = "Exit";
            this.ExitUButton.UseVisualStyleBackColor = false;
            this.ExitUButton.Click += new System.EventHandler(this.ExitUButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 81);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hello, user! What would you like to watch today?";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jomuzfi.Properties.Resources._7r;
            this.ClientSize = new System.Drawing.Size(836, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitUButton);
            this.Controls.Add(this.BackUButton);
            this.Controls.Add(this.MovielistUButton);
            this.Controls.Add(this.WatchlistButton);
            this.Controls.Add(this.DeleteWButton);
            this.Controls.Add(this.AddWButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.Text = "User Mode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddWButton;
        private System.Windows.Forms.Button DeleteWButton;
        private System.Windows.Forms.Button WatchlistButton;
        private System.Windows.Forms.Button MovielistUButton;
        private System.Windows.Forms.Button BackUButton;
        private System.Windows.Forms.Button ExitUButton;
        private System.Windows.Forms.Label label1;
    }
}