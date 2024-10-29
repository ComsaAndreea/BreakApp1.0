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
    public partial class PreUser : Form
    {
        public PreUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm form2 = new UserForm();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //Show the hidden Form (fara a o crea din nou)
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Login);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            Hide();
        }

        private void SpieleButton_Click(object sender, EventArgs e)
        {
            SpieleForm form2 = new SpieleForm();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }
    }
}
