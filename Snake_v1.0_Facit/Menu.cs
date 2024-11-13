using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit
{
    public class Menu
    {
        public void ShowMenu(out string userAction, out string Dificalty)
        {
            Console.Clear();
            Console.WriteLine("1: How to play");
            Console.WriteLine("2: Play");
            Console.WriteLine("3: Exit");

            userAction = Console.ReadLine().ToLower();

            if (userAction == "2")
            {
                Console.Clear();
                Console.WriteLine("1: Easy");
                Console.WriteLine("2: Hard");
                Console.WriteLine("3: INSANE!!!");
                
            }
            Dificalty = Console.ReadLine().ToLower();
        }

    }
}
