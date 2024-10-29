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
    public partial class WatchlistInUser : Form
    {
        public WatchlistInUser()
        {
            InitializeComponent();
            //Einfugen der Daten uber die Filme in der Watchliste
            for (int i = 0; i < Listclass.wlen; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = Listclass.watchlist[i].getTitle();
                row.Cells[1].Value = Listclass.watchlist[i].getYear().ToString();
                row.Cells[2].Value = Listclass.watchlist[i].getGenre();
                row.Cells[3].Value = Listclass.watchlist[i].getLikes().ToString();
                row.Cells[4].Value = Listclass.watchlist[i].getTrailer();
                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Show the hidden Form (fara a o crea din nou)
            /*var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is UserForm);
            if (formToShow != null)
            {
                formToShow.Show();
            }*/
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText.Contains("TRAILER"))
            {
                if (!String.IsNullOrWhiteSpace(dataGridView1.CurrentCell.EditedFormattedValue.ToString()))
                {
                    try 
                    { 
                        System.Diagnostics.Process.Start(dataGridView1.CurrentCell.EditedFormattedValue + "");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("To open the link, make sure that you use http://www.yoursite.com");
                    }
                }
            }
        }

        private void WatchlistInUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
