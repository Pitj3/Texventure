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
            addOption("Start new game", newGame, TextFlags.TEXT_CENTERED_X | TextFlags.TEXT_CENTERED_Y);
            addOption("Help", help);
            addOption("Quit", quit);
        }
    }
}
