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
    public partial class DeleteInUser : Form
    {
        public DeleteInUser()
        {
            InitializeComponent();
            listView1.Items.Clear();
            listView1.View = View.Details;
            for (int i = 0; i < Listclass.wlen; i++)
            {
                ListViewItem liv = listView1.Items.Add(Listclass.watchlist[i].getTitle());
                liv.SubItems.Add(Listclass.watchlist[i].getYear().ToString());
                liv.SubItems.Add(Listclass.watchlist[i].getGenre());
                liv.SubItems.Add(Listclass.watchlist[i].getLikes().ToString());
                liv.SubItems.Add(Listclass.watchlist[i].getTrailer());
            }
        }
        
        //BackButton
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

        private string title;
        private int year;
		
        //DeleteButton
        private void button2_Click(object sender, EventArgs e)
        {
            Listclass.r.delete_movie_watchlist(title,year);
            //afisare lista editata
            listView1.Items.Clear();
            listView1.View = View.Details;
            for (int i = 0; i < Listclass.wlen; i++)
            {
                ListViewItem liv = listView1.Items.Add(Listclass.watchlist[i].getTitle());
                liv.SubItems.Add(Listclass.watchlist[i].getYear().ToString());
                liv.SubItems.Add(Listclass.watchlist[i].getGenre());
                liv.SubItems.Add(Listclass.watchlist[i].getLikes().ToString());
                liv.SubItems.Add(Listclass.watchlist[i].getTrailer());
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //wir nehmen den Index der selektierten Reihe und speichern es, damit wir es weiter benutzen konnen
            if (e.ItemIndex >= 0)
            {
                int x = e.ItemIndex;
                title = Jomuzfi.Listclass.watchlist[e.ItemIndex].getTitle();
                year = Jomuzfi.Listclass.watchlist[e.ItemIndex].getYear();
            }
        }
    }
}
