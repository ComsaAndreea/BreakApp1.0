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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void MovielistButton_Click(object sender, EventArgs e)
        {
            Movielist form2 = new Movielist();
            form2.Tag = this;
            form2.Show(this);
        }

        private void BackUButton_Click(object sender, EventArgs e)
        {
            //Show the hidden Form (fara a o crea din nou)
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is PreUser);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            Hide();
        }

        private void ExitUButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WatchlistButton_Click(object sender, EventArgs e)
        {
            WatchlistInUser form2 = new WatchlistInUser();
            form2.Tag = this;
            form2.Show(this);
        }

        private void AddWButton_Click(object sender, EventArgs e)
        {
            AddInUser form2 = new AddInUser();
            form2.Tag = this;
            form2.Show(this);
        }

        private void DeleteWButton_Click(object sender, EventArgs e)
        {
            DeleteInUser form2 = new DeleteInUser();
            form2.Tag = this;
            form2.Show(this);
        }
    }
}
