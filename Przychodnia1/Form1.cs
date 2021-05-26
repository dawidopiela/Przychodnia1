using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia1
{
    public partial class Form1 : MetroSetForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroSetTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroSetLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
           using (Zaloguj zaloguj = new Zaloguj())
               zaloguj.ShowDialog();



        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            using (Rejestracja rejestracja = new Rejestracja())
                rejestracja.ShowDialog();
        }

        private void metroSetListBox1_SelectedIndexChanged(object sender)
        {
           
        }

        private void metroSetButton4_Click(object sender, EventArgs e)
        {
            using (Administrator administrator = new Administrator())
               administrator.ShowDialog();
        }
    }
}
