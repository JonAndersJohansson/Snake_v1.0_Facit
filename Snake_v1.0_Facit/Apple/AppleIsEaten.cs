using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Apple
{
    public class AppleIsEaten
    {
        public bool DetermineIfAppleIsEaten(int xPosition, int yPosition, int xPositionApple, int yPositionApple)
        {
            // Om snake huvud är på samma position som ett äpple... ät det!
            if (xPosition == xPositionApple && yPosition == yPositionApple) return true; return false;
        }
    }
}
