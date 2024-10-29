using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jomuzfi
{
    public partial class AddInUser : Form
    {
        public AddInUser()
        {
            InitializeComponent();
            //Einfugen der Daten uber die Filme in der ganzen Liste
            for (int i = 0; i < Listclass.length; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = Listclass.movies[i].getTitle();
                row.Cells[1].Value = Listclass.movies[i].getYear().ToString();
                row.Cells[2].Value = Listclass.movies[i].getGenre();
                row.Cells[3].Value = Listclass.movies[i].getLikes().ToString();
                row.Cells[4].Value = Listclass.movies[i].getTrailer();
                dataGridView1.Rows.Add(row);
            }
        }

        //Programmieren der HyperLinks, so dass sie funktionieren
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText.Contains("TRAILER"))
            {
                try
                {
                    if (!String.IsNullOrWhiteSpace(dataGridView1.CurrentCell.EditedFormattedValue.ToString()))
                    {
                        System.Diagnostics.Process.Start(dataGridView1.CurrentCell.EditedFormattedValue + "");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("To open the link, make sure that you use http://www.yoursite.com");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Show the hidden Form (fara a o crea din nou)
            /*var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is UserForm);
            if (formToShow != null)
            {
                formToShow.Show();
            }*/
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //wir nehmen den Index der selektierten Reihe und speichern es, damit wir es weiter benutzen konnen
            int index = dataGridView1.CurrentCell.RowIndex;
            Movie addmovie = new Movie();
            addmovie.setTitle(dataGridView1.Rows[index].Cells[0].Value.ToString());
            addmovie.setYear(Int32.Parse(dataGridView1.Rows[index].Cells[1].Value.ToString()));
            addmovie.setGenre(dataGridView1.Rows[index].Cells[2].Value.ToString());
            addmovie.setLikes(Int32.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString()));
            addmovie.setTrailer(dataGridView1.Rows[index].Cells[4].Value.ToString());
            Listclass.r.add_movie2(addmovie, "user");
        }
    }
}
