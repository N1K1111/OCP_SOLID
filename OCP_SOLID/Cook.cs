using OCP_SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_SOLID
{
    internal class Cook
    {
        public string Name {  get; set; }
        public Cook(string name)
        {
            Name = name;
        }

        public void MakeDiner(IMeal meal)
        {
            meal.Make();
        }

        public void MakeDiner(MealBase[] menu)
        {
            foreach (var m in menu)
            {
                m.Make();
            }

        }
    }
}
