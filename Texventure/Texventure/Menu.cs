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
    }

    public class Menu : Panel
    {
        public delegate void option();
        Dictionary<MenuStringID, option> menuList = new Dictionary<MenuStringID, option>();

        public uint currentlySelected = 0;

        public Menu() { }

        public override void render()
        {
            Console.Clear();

            int i = 0;
            foreach (KeyValuePair<MenuStringID, option> pair in menuList)
            {
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
        }

        public void addOption(string text, option function)
        {
            MenuStringID id = new MenuStringID();
            id.id = (uint)menuList.Count;
            id.text = text;
            menuList.Add(id, function);
        }
    }
}
