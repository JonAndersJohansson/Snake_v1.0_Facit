using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit
{
    public class Varibals
    {

        

        public int xPositionApple = 10;
        public int yPositionApple = 10;
        public int applesEaten = 0;
        public Random random = new Random();

        // Ta bort cursor... endast estetiskt

        public string userAction = " ";

        public decimal gameSpeed = 150m;

        public bool isGameOn = true;
        public bool isWallHit = false;
        public bool isAppleEaten = false;
        public bool isStayInMenu = true;



    }
}
