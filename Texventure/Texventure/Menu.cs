using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Texventure
{
    public struct MenuStringID
    {
        public uint id;
        public string text;
        public int flags;
    }

    public class Menu : Panel
    {
        public delegate void option();
        Dictionary<MenuStringID, option> menuList = new Dictionary<MenuStringID, option>();

        public uint currentlySelected = 0;

        public Menu() { }

        public override void render(int flags)
        {
            Console.Clear();

            int yoffset = 0;

            if((flags & TextFlags.TEXT_CENTERED_Y) == TextFlags.TEXT_CENTERED_Y)
            {
                yoffset = (int)(Game.height - menuList.Count) / 2;
                for(int y = 0; y < yoffset; y++)
                {
                    Console.WriteLine();
                }
            }

            int i = 0;
            foreach (KeyValuePair<MenuStringID, option> pair in menuList)
            {
                int xoffset = 0;
                if((pair.Key.flags & TextFlags.TEXT_CENTERED_X) == TextFlags.TEXT_CENTERED_X)
                {
                    // center text on x
                    xoffset = (int)(Game.width - (pair.Key.text.Length + 3)) / 2;
                }
                if ((pair.Key.flags & TextFlags.TEXT_CENTERED_Y) == TextFlags.TEXT_CENTERED_Y)
                {
                    // center text on x
                }

                if(xoffset > 0)
                {
                    Console.Write("".PadLeft(xoffset, ' '));
                }

                if (i == currentlySelected)
                    Console.Write(" - ");
                else
                    Console.Write("   ");

                Console.Write(pair.Key.text);
                Console.Write("\n");

                i++;
            }

            ConsoleKeyInfo key = Console.ReadKey();
            switch(key.Key)
            {
                case ConsoleKey.DownArrow:
                {
                    currentlySelected++;
                    break;
                }

                case ConsoleKey.UpArrow:
                {
                    currentlySelected--;
                    break;
                }

                case ConsoleKey.Enter:
                {
                    menuList.ElementAt((int)currentlySelected).Value.Invoke();
                    break;
                }
            }

            currentlySelected = Mathf.Clamp<uint>(currentlySelected, 0, (uint)menuList.Count - 1);
        }

        public void addOption(string text, option function, int flags = 0)
        {
            MenuStringID id = new MenuStringID();
            id.id = (uint)menuList.Count;
            id.text = text;
            id.flags = flags;
            menuList.Add(id, function);
        }
    }
}
