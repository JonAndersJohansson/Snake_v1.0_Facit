using Snake_v1._0_Facit.Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit
{
    public class MenuChoice : Varibals
    {
        public void MakeAChoice(Menu menu, Instruction instruction, StartGame startGame, BuildPlayBoard buildPlayBoard)
        {
            do
            {
                // Gör en välkomstskärm (meny)
                // Låt spelaren läser instruktionerna om han vill
                menu.ShowMenu(out userAction);

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
                        instruction.ShowInstructions(userAction, buildPlayBoard);
                        break;
                    case "2":
                        startGame.Start(xPosition, yPosition);
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
