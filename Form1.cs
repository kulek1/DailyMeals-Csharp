using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektnaPO
{
    public partial class Form1 : Form
    {
        Profil profil = new Profil();

        public Form1()
        {
            InitializeComponent();
            Updater();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Profil okno = new ProjektnaPO.Profil();
            okno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListForm lista = new ProjektnaPO.ListForm();
            lista.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        public void Updater()
        {
            int kcal_DB = 0;
            int protein_DB = 0;
            int carbs_DB = 0;
            int fats_DB = 0;

            int kcal_SETTINGS = Int32.Parse(Properties.Settings.Default.kcal.ToString());
            int protein_SETTINGS = Int32.Parse(Properties.Settings.Default.protein.ToString());
            int carbs_SETTINGS = Int32.Parse(Properties.Settings.Default.carb.ToString());
            int fats_SETTINGS = Int32.Parse(Properties.Settings.Default.fat.ToString());



            Labelcarbs.Text = Properties.Settings.Default.carb.ToString();
            Labelfat.Text = Properties.Settings.Default.fat.ToString();

            // SQL Meals
            SqlConnection connect = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DbMeals;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True");
            connect.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.MEALS", connect);
            using (SqlDataAdapter da = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    kcal_DB  += Convert.ToInt16(row[2]);
                    protein_DB  += Convert.ToInt16(row[3]);
                    carbs_DB  += Convert.ToInt16(row[4]);
                    fats_DB  += Convert.ToInt16(row[5]);
                }
            }
            // kcal
            kcal_SETTINGS = kcal_SETTINGS - kcal_DB;
            Labelkcal.Text = kcal_SETTINGS.ToString();
            // protein
            protein_SETTINGS = protein_SETTINGS - protein_DB;
            Labelprotein.Text = protein_SETTINGS.ToString();
            // carbs
            carbs_SETTINGS = carbs_SETTINGS - carbs_DB;
            Labelcarbs.Text = carbs_SETTINGS.ToString();
            // fat
            fats_SETTINGS = fats_SETTINGS - fats_DB;
            Labelfat.Text = fats_SETTINGS.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddForm addform = new ProjektnaPO.AddForm();
            addform.Show();
        }
    }
}
