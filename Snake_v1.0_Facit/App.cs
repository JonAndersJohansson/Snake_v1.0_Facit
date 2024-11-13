using Snake_v1._0_Facit.Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit
{
    internal class App
    {
        internal void GoGame()
        {
            Console.CursorVisible = false;

            int xPositionApple = 10;
            int yPositionApple = 10;
            int applesEaten = 0;
            Random random = new Random();
            string userAction = " ";
            decimal gameSpeed = 150m;

            string Dificalty = " ";

            bool isGameOn = true;
            bool isWallHit = false;
            bool isAppleEaten = false;

            var menu = new Menu();
            var menuChoice = new MenuChoice();
            var build = new BuildPlayBoard();
            var instruction = new Instruction();
            var startGame = new StartGame();

            menuChoice.MakeAChoice(menu, instruction, startGame,
            build, userAction, isGameOn, applesEaten, random, isWallHit, isAppleEaten, gameSpeed, Dificalty);


        }

    }
}
