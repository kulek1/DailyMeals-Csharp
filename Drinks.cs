using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektnaPO
{
    class Drinks : Meals
    {
        protected int liquid;

        public Drinks(String name, int kcal, int protein, int carbs, int fats, int liquid) : base (name, kcal, protein, carbs, fats)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fats = fats;
            this.liquid = liquid;

            DbHelper temp = new DbHelper(name, kcal, protein, carbs, fats, liquid);
            temp.saveMeal(true);
        }
        public int getLiquid()
        {
            return liquid;
        }
    }
}
