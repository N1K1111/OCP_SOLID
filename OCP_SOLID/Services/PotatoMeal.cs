using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCP_SOLID.Interfaces;

namespace OCP_SOLID.Services
{
    internal class PotatoMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Готовим картофельное пюре");
        }
    }
}
