namespace Jomuzfi
{
    partial class AdminForm
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
            this.AddMButton = new System.Windows.Forms.Button();
            this.DeleteMButton = new System.Windows.Forms.Button();
            this.BackAButton = new System.Windows.Forms.Button();
            this.EditMButton = new System.Windows.Forms.Button();
            this.MovielistAButton = new System.Windows.Forms.Button();
            this.ExitAButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddMButton
            // 
            this.AddMButton.BackColor = System.Drawing.Color.Coral;
            this.AddMButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMButton.Location = new System.Drawing.Point(90, 129);
            this.AddMButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddMButton.Name = "AddMButton";
            this.AddMButton.Size = new System.Drawing.Size(124, 44);
            this.AddMButton.TabIndex = 0;
            this.AddMButton.Text = "Add";
            this.AddMButton.UseVisualStyleBackColor = false;
            this.AddMButton.Click += new System.EventHandler(this.AddMButton_Click);
            // 
            // DeleteMButton
            // 
            this.DeleteMButton.BackColor = System.Drawing.Color.Coral;
            this.DeleteMButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMButton.Location = new System.Drawing.Point(90, 277);
            this.DeleteMButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteMButton.Name = "DeleteMButton";
            this.DeleteMButton.Size = new System.Drawing.Size(124, 44);
            this.DeleteMButton.TabIndex = 1;
            this.DeleteMButton.Text = "Delete";
            this.DeleteMButton.UseVisualStyleBackColor = false;
            this.DeleteMButton.Click += new System.EventHandler(this.DeleteMButton_Click);
            // 
            // BackAButton
            // 
            this.BackAButton.BackColor = System.Drawing.Color.Khaki;
            this.BackAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackAButton.Location = new System.Drawing.Point(46, 411);
            this.BackAButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackAButton.Name = "BackAButton";
            this.BackAButton.Size = new System.Drawing.Size(139, 43);
            this.BackAButton.TabIndex = 2;
            this.BackAButton.Text = "Back";
            this.BackAButton.UseVisualStyleBackColor = false;
            this.BackAButton.Click += new System.EventHandler(this.BackAButton_Click);
            // 
            // EditMButton
            // 
            this.EditMButton.BackColor = System.Drawing.Color.Coral;
            this.EditMButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMButton.Location = new System.Drawing.Point(89, 203);
            this.EditMButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditMButton.Name = "EditMButton";
            this.EditMButton.Size = new System.Drawing.Size(124, 44);
            this.EditMButton.TabIndex = 3;
            this.EditMButton.Text = "Edit";
            this.EditMButton.UseVisualStyleBackColor = false;
            this.EditMButton.Click += new System.EventHandler(this.EditMButton_Click);
            // 
            // MovielistAButton
            // 
            this.MovielistAButton.BackColor = System.Drawing.Color.Coral;
            this.MovielistAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovielistAButton.Location = new System.Drawing.Point(267, 129);
            this.MovielistAButton.Margin = new System.Windows.Forms.Padding(4);
            this.MovielistAButton.Name = "MovielistAButton";
            this.MovielistAButton.Size = new System.Drawing.Size(124, 44);
            this.MovielistAButton.TabIndex = 4;
            this.MovielistAButton.Text = "Movielist";
            this.MovielistAButton.UseVisualStyleBackColor = false;
            this.MovielistAButton.Click += new System.EventHandler(this.MovielistAButton_Click);
            // 
            // ExitAButton
            // 
            this.ExitAButton.BackColor = System.Drawing.Color.Khaki;
            this.ExitAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitAButton.Location = new System.Drawing.Point(676, 411);
            this.ExitAButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitAButton.Name = "ExitAButton";
            this.ExitAButton.Size = new System.Drawing.Size(140, 43);
            this.ExitAButton.TabIndex = 5;
            this.ExitAButton.Text = "Exit";
            this.ExitAButton.UseVisualStyleBackColor = false;
            this.ExitAButton.Click += new System.EventHandler(this.ExitAButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 81);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hello, admin! What do you want to change today?";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = global::Jomuzfi.Properties.Resources._3r;
            this.ClientSize = new System.Drawing.Size(857, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitAButton);
            this.Controls.Add(this.MovielistAButton);
            this.Controls.Add(this.EditMButton);
            this.Controls.Add(this.BackAButton);
            this.Controls.Add(this.DeleteMButton);
            this.Controls.Add(this.AddMButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "Admin Mode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddMButton;
        private System.Windows.Forms.Button DeleteMButton;
        private System.Windows.Forms.Button BackAButton;
        private System.Windows.Forms.Button EditMButton;
        private System.Windows.Forms.Button MovielistAButton;
        private System.Windows.Forms.Button ExitAButton;
        private System.Windows.Forms.Label label1;
    }
}