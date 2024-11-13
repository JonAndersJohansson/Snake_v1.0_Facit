using Snake_v1._0_Facit.Apple;
using Snake_v1._0_Facit.Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit
{
    public class StartGame
    {
        public void Start(int[] xPosition, int[] yPosition, int applesEaten, Random random, out int xPositionApple,
            out int yPositionApple, bool isWallHit, bool isGameOn, bool isAppleEaten, decimal gameSpeed) 
        {

            var snakepaint = new SnakePaint();
            var snakehitwall = new SnakeHitWall();

            var appleeaten = new AppleIsEaten();
            var applepaint = new ApplePaint();
            var setapplep = new SetApplePosition();

            var buildplayb = new BuildPlayBoard();


            Console.Clear();
            // Visa new snake array på skrämen
            snakepaint.PaintSnake(applesEaten, xPosition, yPosition, out xPosition, out yPosition);

            // Placera FÖRSTA äpplet random ställe på skärmen
            // out - ändrar de globala variabler också (inte bara de lokala inom metoden)
            setapplep.SetApplePositionOnScreen(random, out xPositionApple, out yPositionApple);
            applepaint.PaintApple(xPositionApple, yPositionApple);

            // Rita border
            buildplayb.BuildWall();

            // Läs instruktion från användaren
            ConsoleKey command = Console.ReadKey().Key;

            // Flytta på snake
            do
            {
                switch (command)
                {
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(xPosition[0], yPosition[0]);
                        Console.Write(" ");
                        xPosition[0]--;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(xPosition[0], yPosition[0]);
                        Console.Write(" ");
                        yPosition[0]--;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(xPosition[0], yPosition[0]);
                        Console.Write(" ");
                        xPosition[0]++;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(xPosition[0], yPosition[0]);
                        Console.Write(" ");
                        yPosition[0]++;
                        break;
                }

                // Visa new snake array på skrämen
                snakepaint.PaintSnake(applesEaten, xPosition, yPosition, out xPosition, out yPosition);

                // Känner av när snake (head) träffa väggen
                isWallHit = snakehitwall.DidSnakeHitWall(xPosition[0], yPosition[0]);

                if (isWallHit)
                {
                    isGameOn = false;
                    Console.SetCursorPosition(32, 20);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game Over");

                    // Visa final score
                    Console.SetCursorPosition(30, 22);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(@"Din score är ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(applesEaten);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(20, 24);
                    Console.WriteLine("Tryck på valfri knapp för att fortsätta");
                    applesEaten = 0;

                    // Raderar äpplet vid game over
                    Console.SetCursorPosition(xPositionApple, yPositionApple);
                    Console.Write(" ");

                    Console.ReadLine();
                    Console.Clear();

                    // Låt spelaren välja att spela igen
                    // ShowMenu(out userAction);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(1, 42);
                }

                // Känner av om äpplet har ätits upp av snake
                isAppleEaten = appleeaten.DetermineIfAppleIsEaten(xPosition[0], yPosition[0], xPositionApple, yPositionApple);

                if (isAppleEaten)
                {
                    // Placera äpple random ställe på skärmen
                    // out - ändrar de globala variabler också (inte bara de lokala inom metoden)
                    setapplep.SetApplePositionOnScreen(random, out xPositionApple, out yPositionApple);
                    applepaint.PaintApple(xPositionApple, yPositionApple);

                    // Lägg antalet uppätna äpplen i en variabel (score)
                    applesEaten++;
                    // Gör snake snabbare
                    gameSpeed *= .925m;
                }

                if (Console.KeyAvailable) command = Console.ReadKey().Key;

                // Slow game down
                System.Threading.Thread.Sleep(Convert.ToInt32(gameSpeed));

            } while (isGameOn);
        }
    }
}
 