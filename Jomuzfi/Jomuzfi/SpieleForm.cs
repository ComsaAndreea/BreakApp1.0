using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jomuzfi
{
    public partial class SpieleForm : Form
    {
        public SpieleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(ConfigurationManager.AppSettings["SeaStone"]))
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.Arguments = "A";
                processStartInfo.FileName = ConfigurationManager.AppSettings["SeaStone"];
                Process.Start(processStartInfo);
            }
            else
            {
                MessageBox.Show("Nu sunt jocuri de afisat.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(ConfigurationManager.AppSettings["Crab"]))
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.Arguments = "A";
                processStartInfo.FileName = ConfigurationManager.AppSettings["Crab"];
                Process.Start(processStartInfo);
            }
            else
            {
                MessageBox.Show("Nu sunt jocuri de afisat.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(ConfigurationManager.AppSettings["Colors"]))
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.Arguments = "A";
                processStartInfo.FileName = ConfigurationManager.AppSettings["Colors"];
                Process.Start(processStartInfo);
            }
            else
            {
                MessageBox.Show("Nu sunt jocuri de afisat.");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //Show the hidden Form (fara a o crea din nou)
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is PreUser);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(ConfigurationManager.AppSettings["Fahnenspiel"]))
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.Arguments = "A";
                processStartInfo.FileName = ConfigurationManager.AppSettings["Fahnenspiel"];
                Process.Start(processStartInfo);
            }
            else
            {
                MessageBox.Show("Nu sunt jocuri de afisat.");
            }
        }
    }
}
