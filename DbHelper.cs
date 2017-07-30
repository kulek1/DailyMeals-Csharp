using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjektnaPO
{
    public class DbHelper
    {
        protected String name;
        protected int kcal;
        protected int protein;
        protected int carbs;
        protected int fats;
        protected int liquid;

        public DbHelper(String name, int kcal, int protein, int carbs, int fats)
        {
            this.name = name;
            this.kcal = kcal;
            this.protein = protein;
            this.carbs = carbs;
            this.fats = fats;
        }
        public DbHelper(String name, int kcal, int protein, int carbs, int fats, int liquid)
        {
            this.name = name;
            this.kcal = kcal;
            this.protein = protein;
            this.carbs = carbs;
            this.fats = fats;
            this.liquid = liquid;
        }
        public void saveMeal(bool ifLiquid)
        {
            SqlConnection connect = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=DbMeals;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True");
            connect.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.meals (Name,Kcal,Protein,Carbo,Fats) VALUES (@Name,@Kcal,@Protein,@Carbo,@Fats)", connect);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Kcal", kcal);
            cmd.Parameters.AddWithValue("@Protein", protein);
            cmd.Parameters.AddWithValue("@Carbo", carbs);
            cmd.Parameters.AddWithValue("@Fats", fats);
            if(ifLiquid)
            {
                cmd.Parameters.AddWithValue("@Liquid", liquid);
            }
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public int getLiquid()
        {
            return liquid;
        }
        public String getName()
        {
            return name;
        }
        public int getKcal()
        {
            return kcal;
        }
        public int getProtein()
        {
            return protein;
        }
        public int getCarbs()
        {
            return carbs;
        }
        public int getFats()
        {
            return fats;
        }
    }
}
