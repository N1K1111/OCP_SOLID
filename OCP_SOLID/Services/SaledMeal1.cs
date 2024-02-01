using OCP_SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_SOLID.Services
{
    internal class SaledMeal1 : MealBase
    {
        protected override void Cook()
        {
            Console.WriteLine("Нарезаем огурцы и помидоры");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Посыпаем специями и салат готов");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Моем овощи");
        }
    }
}
