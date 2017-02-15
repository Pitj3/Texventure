using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Texventure;

namespace Texventure_Game
{
    public class MainMenu : Menu
    {
        public void newGame()
        {

        }

        public void help()
        {

        }

        public void quit()
        {
            Environment.Exit(0);
        }

        public MainMenu()
        {
            addOption("Start new game", newGame);
            addOption("Help", help);
            addOption("Quit", quit);
        }
    }
}
