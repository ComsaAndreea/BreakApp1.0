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
    public partial class AddInAdmin : Form
    {
        public AddInAdmin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Movie addmovie = new Movie();
                addmovie.setTitle(textBox1.Text);
                addmovie.setYear(Int32.Parse(textBox2.Text));
                addmovie.setGenre(textBox3.Text);
                addmovie.setLikes(Int32.Parse(textBox4.Text));
                addmovie.setTrailer(textBox5.Text);
                Listclass.r.add_movie2(addmovie, "admin");
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Please complete all fields first!");
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

        private void AddInAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
