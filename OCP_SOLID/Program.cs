using OCP_SOLID.Interfaces;
using OCP_SOLID.Services;

namespace OCP_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cook cook = new Cook("Никита");
            cook.MakeDiner(new PotatoMeal());
            Console.WriteLine();
            cook.MakeDiner(new SaledMeal());

            Console.WriteLine("-----------------------------");

            cook.MakeDiner(new MealBase []{ new SaledMeal1(),new PotatoMeal1()});
        }
    }
}
