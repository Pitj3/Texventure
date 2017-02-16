using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Texventure;

namespace Texventure_Game
{
    public class TestGame : Game, InputListener
    {
        MainMenu mainMenu;

        public override void initialize(uint width, uint height, string title)
        {
            base.initialize(width, height, title);

            TexConsole con = new TexConsole(width, height, title);

            mainMenu = new MainMenu();
            currentPanel = mainMenu;
        }

        public override void run()
        {
            base.run();

            while(isRunning())
            {
                if (currentPanel != null)
                    currentPanel.render(TextFlags.TEXT_CENTERED_Y);
                else
                    parseInputLine(Console.ReadLine());
            }
        }

        public override void close()
        {
            base.close();
        }

        public override void parseInputLine(string input)
        {
            if (input == "exit")
                Environment.Exit(0);
        }
    }
}
