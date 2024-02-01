using OCP_SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_SOLID.Services
{
    internal class PotatoMeal1 : MealBase
    {
        protected override void Cook()
        {
            Console.WriteLine("Чистим картошку");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Готовим");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Нарезаем");
        }
    }
}
