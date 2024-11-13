using Snake_v1._0_Facit.Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit
{
    internal class App : Varibals
    {
        internal void GoGame()
        {
            Console.CursorVisible = false;

            var menu = new Menu();
            var menuChoice = new MenuChoice();
            var build = new BuildPlayBoard();
            var instruction = new Instruction();
            var startGame = new StartGame();

            menuChoice.MakeAChoice(menu, instruction, startGame, build);


        }

    }
}
