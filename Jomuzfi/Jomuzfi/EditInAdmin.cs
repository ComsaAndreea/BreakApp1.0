using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jomuzfi
{
    public partial class EditInAdmin : Form
    {
        int x = -1;
        public EditInAdmin()
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

        private void Button2_Click(object sender, EventArgs e)
        {
            //Show the hidden Form (fara a o crea din nou)
            /*var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is AdminForm);
            if (formToShow != null)
            {
                formToShow.Show();
            }*/
            this.Hide();
        }

        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.ItemIndex >= 0)
            {
                x=e.ItemIndex;
                title.Text = Jomuzfi.Listclass.movies[e.ItemIndex].getTitle();
                year.Text = Jomuzfi.Listclass.movies[e.ItemIndex].getYear().ToString();
                genre.Text = Jomuzfi.Listclass.movies[e.ItemIndex].getGenre();
                likes.Text = Jomuzfi.Listclass.movies[e.ItemIndex].getLikes().ToString();
                trailer.Text = Jomuzfi.Listclass.movies[e.ItemIndex].getTrailer();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Jomuzfi.Listclass.movies[x].setTitle(title.Text);
            Jomuzfi.Listclass.movies[x].setYear(Int32.Parse(year.Text));
            Jomuzfi.Listclass.movies[x].setGenre(genre.Text);
            Jomuzfi.Listclass.movies[x].setLikes(Int32.Parse(likes.Text));
            Jomuzfi.Listclass.movies[x].setTrailer(trailer.Text);
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

        private void EditInAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
