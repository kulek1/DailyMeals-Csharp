using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektnaPO
{
    public class Meals
    {
        protected String name;
        protected int kcal;
        protected int protein;
        protected int carbs;
        protected int fats;

        public Meals(String name, int kcal, int protein, int carbs, int fats)
        {
            DbHelper temp = new DbHelper(name, kcal, protein, carbs, fats);
            temp.saveMeal(false);

            this.name = name;
            this.kcal = kcal;
            this.protein = protein;
            this.carbs = carbs;
            this.fats = fats;
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
