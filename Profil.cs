using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektnaPO
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
            ReloadForm();
        }
        private void ReloadForm()
        {
            numericUpDownKCAL.Value = Properties.Settings.Default.kcal;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.kcal = (int) numericUpDownKCAL.Value;
            Properties.Settings.Default.protein = (int)numericUpDownPROTEIN.Value;
            Properties.Settings.Default.carb = (int)numericUpDownCARBS.Value;
            Properties.Settings.Default.fat = (int)numericUpDownFAT.Value;
            if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).Updater();
            }
        }

        private void Profil_Load(object sender, EventArgs e)
        {

        }
    }
}
