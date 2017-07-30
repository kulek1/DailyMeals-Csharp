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
    public partial class AddForm : Form
    {
        bool withLiquid = false;

        public AddForm()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            // label liquid
            label7.Visible = false;

            button1.Visible = false;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if ((ctrl as TextBox) != null && (ctrl as TextBox).Name != "textBox1")
                {
                    (ctrl as TextBox).TextChanged += AddForm_TextChanged;
                }
            }
        }
        private void AddForm_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, "[^0-9]"))
            {
                MessageBox.Show("Proszę wprowadzić tylko liczby.");
                (sender as TextBox).Text = (sender as TextBox).Text.Remove((sender as TextBox).Text.Length - 1);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            // check if text boxes are empty
            bool ifEmpty = false;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        ifEmpty = true;
                    }
                }
            }
            if(!ifEmpty)
            {
                String labelName = textBox1.Text;
                int labelKcal = Int32.Parse(textBox2.Text);
                int labelProtein = Int32.Parse(textBox3.Text);
                int labelCarbs = Int32.Parse(textBox4.Text);
                int labelFats = Int32.Parse(textBox5.Text);
                int labelLiquid = Int32.Parse(textBox6.Text);



                if (withLiquid)
                {
                    Drinks drink = new Drinks(labelName, labelKcal, labelProtein, labelCarbs, labelFats, labelLiquid);
                }
                else
                {
                    Meals obj = new Meals(labelName, labelKcal, labelProtein, labelCarbs, labelFats);
                }

                MessageBox.Show("Twój posiłek został dodany!");

                // update others forms
                Object ListForm_Obj = new Object();
                Object Form1_Obj = new object();

                ListForm_Obj = System.Windows.Forms.Application.OpenForms["ListForm"];
                Form1_Obj = System.Windows.Forms.Application.OpenForms["Form1"];
                if (ListForm_Obj != null)
                {
                    (ListForm_Obj as ListForm).listViewUpdater();
                }
                if(Form1_Obj != null)
                {
                    (Form1_Obj as Form1).Updater();
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij poprawnie wszystkie pola");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            label6.Visible = false;

            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;

            withLiquid = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            // label liquid
            label7.Visible = true;

            label6.Visible = false;

            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;

            withLiquid = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
