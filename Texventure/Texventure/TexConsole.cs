using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texventure
{
    public class TexConsole
    {
        public TexConsole()
        {
            Console.SetWindowSize(80, 20);
            Console.Title = "Texventure window";
        }

        public TexConsole(uint width, uint height, string title) : base()
        {
            Console.SetWindowSize((int)width, (int)height);
            Console.Title = title;
        }
    }
}
