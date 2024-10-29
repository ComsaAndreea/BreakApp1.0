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
    public partial class DeleteInAdmin : Form
    {
        public DeleteInAdmin()
        {
            InitializeComponent();
            listView1.View = View.Details;
            for (int i = 0; i < Listclass.length; i++)
            {
                ListViewItem liv = listView1.Items.Add(Listclass.movies[i].getTitle());
                liv.SubItems.Add(Listclass.movies[i].getYear().ToString());
                liv.SubItems.Add(Listclass.movies[i].getGenre());
                liv.SubItems.Add(Listclass.movies[i].getLikes().ToString());
                liv.SubItems.Add(Listclass.movies[i].getTrailer());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Show the hidden Form (fara a o crea din nou)
            /*var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is AdminForm);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            */
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {       
            Listclass.r.delete_movie_list(title, year);
            //afisare lista editata
            listView1.Items.Clear();
            listView1.View = View.Details;
            for (int i = 0; i < Listclass.length; i++)
            {
                ListViewItem liv = listView1.Items.Add(Listclass.movies[i].getTitle());
                liv.SubItems.Add(Listclass.movies[i].getYear().ToString());
                liv.SubItems.Add(Listclass.movies[i].getGenre());
                liv.SubItems.Add(Listclass.movies[i].getLikes().ToString());
                liv.SubItems.Add(Listclass.movies[i].getTrailer());
            }
        }
        private string title;
        private int year;

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //wir nehmen den Index der selektierten Reihe und speichern es, damit wir es weiter benutzen konnen
            if (e.ItemIndex >= 0)
            {
                int x = e.ItemIndex;
                title = Jomuzfi.Listclass.movies[e.ItemIndex].getTitle();
                year = Jomuzfi.Listclass.movies[e.ItemIndex].getYear();
            }
        }

        private void DeleteInAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
