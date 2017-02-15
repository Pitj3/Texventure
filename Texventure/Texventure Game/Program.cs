using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Texventure;

namespace Texventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGame game = new TestGame();
            game.initialize(80, 20, "Texventure Game");
            game.run();
            Console.ReadLine();
        }
    }
}
