using Snake_v1._0_Facit.Apple;
using Snake_v1._0_Facit.Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit
{
    public class MenuChoice
    {
        public void MakeAChoice(Menu menu, Instruction instruction, StartGame startGame, 
            BuildPlayBoard buildPlayBoard, string userAction, bool isGameOn, int applesEaten,
            Random random, bool isWallHit, bool isAppleEaten, decimal gameSpeed, string dificalty)
        {
            bool isStayInMenu = true;
            do
            {
            
                // Gör en välkomstskärm (meny)
                // Låt spelaren läser instruktionerna om han vill
                menu.ShowMenu(out userAction, out dificalty);

                // Om spelare väljer att spela igen...
                // Reset snake
                int[] xPosition = new int[50];
                xPosition[0] = 35;
                int[] yPosition = new int[50];
                yPosition[0] = 20;
                // Reset även denna
                isGameOn = true;

                switch (userAction)
                {
                    case "1":
                        instruction.ShowInstructions(buildPlayBoard);
                        break;
                    case "2":
                        if (dificalty == "1")
                            gameSpeed = 500m;
                        else if (dificalty == "2")
                            gameSpeed = 100m;
                        else if (dificalty == "3")
                            gameSpeed = 20m;
                        startGame.Start(xPosition, yPosition, applesEaten, random, out int xPositionApple, out int yPositionApple, isWallHit, isGameOn, isAppleEaten, gameSpeed);
                        break;
                    case "3":
                        isStayInMenu = false;
                        break;
                    default:
                        Console.WriteLine("Inte ett giltigt val. Försök igen");
                        Console.ReadLine();
                        Console.Clear();
                        // ShowMenu(out userAction);
                        break;
                }
            } while (isStayInMenu);
        }
    }
}
