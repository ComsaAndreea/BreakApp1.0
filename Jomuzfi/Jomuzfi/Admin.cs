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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            
            
        }

        private void ExitAButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MovielistAButton_Click(object sender, EventArgs e)
        {
            Movielist form2 = new Movielist();
            form2.Tag = this;
            form2.Show(this);
        }

        private void BackAButton_Click(object sender, EventArgs e)
        {
            //Show the hidden Form (fara a o crea din nou)
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Login);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            Hide();
        }

        private void AddMButton_Click(object sender, EventArgs e)
        {
            AddInAdmin form2 = new AddInAdmin();
            form2.Tag = this;
            form2.Show(this);
        }

        private void DeleteMButton_Click(object sender, EventArgs e)
        {
            DeleteInAdmin form = new DeleteInAdmin();
            form.Tag = this;
            form.Show(this);
        }

        private void EditMButton_Click(object sender, EventArgs e)
        {
            EditInAdmin form = new EditInAdmin();
            form.Tag = this;
            form.Show(this);
        }
    }
}
