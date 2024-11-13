using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Apple
{
    public class ApplePaint
    {
        public void PaintApple(int xPositionApple, int yPositionApple)
        {
            Console.SetCursorPosition(xPositionApple, yPositionApple);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("@");
        }
    }
}
