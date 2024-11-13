using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit
{
    public class Instruction
    {

        public void ShowInstructions(BuildPlayBoard buildPlayBoard)
        {
            Console.Clear();
            buildPlayBoard.BuildWall();
            Console.SetCursorPosition(12, 5);
            Console.WriteLine("Använd pilarna för att flytta ormen runt banan");
            Console.SetCursorPosition(16, 7);
            Console.WriteLine("Ormen dör om den träffar yttreväggen");
            Console.SetCursorPosition(20, 9);
            Console.WriteLine("Ät äpplen för att få poäng!");
            Console.SetCursorPosition(13, 11);
            Console.WriteLine("Varje äpple gör ormen längre och snabbare!");
            Console.SetCursorPosition(14, 13);
            Console.WriteLine("Tryck på valfri knapp för att fortsätta");
            Console.SetCursorPosition(12, 19);
            Console.WriteLine("Use the arrows to move the snake around the track");
            Console.SetCursorPosition(16, 21);
            Console.WriteLine("The snake dies if it hits the outer wall");
            Console.SetCursorPosition(20, 23);
            Console.WriteLine("Eat apples to get points!");
            Console.SetCursorPosition(13, 25);
            Console.WriteLine("Each apple makes the snake longer and faster!");
            Console.SetCursorPosition(20, 27);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            //ShowMenu(out userAction);
        }
    }
}
