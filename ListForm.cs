using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ProjektnaPO
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
            // register EventHandler
            this.listView1.ColumnWidthChanging += new ColumnWidthChangingEventHandler(listView1_ColumnWidthChanging);

            listViewUpdater();

        }

        private void Lista_Load(object sender, EventArgs e)
        {

        }
        void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DbMeals;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True");
            connect.Open();

            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE dbo.MEALS", connect);
            cmd.ExecuteNonQuery();
            listViewUpdater();
            Object form1 = new Object();
            form1 = System.Windows.Forms.Application.OpenForms["Form1"];
            if (form1 != null)
            {
                (form1 as Form1).Updater();
            }
        }
        public void listViewUpdater()
        {
            ListViewItem lvi = new ListViewItem();

            // SQL
            SqlConnection connect = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DbMeals;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True");
            connect.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.MEALS", connect);
            using (SqlDataAdapter da = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                listView1.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[1].ToString());
                    for (int i = 2; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    listView1.Items.Add(item);
                }
            }
            connect.Close();
        }
    }
}
