using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texventure
{
    public class Room : InputListener
    {
        public string title;
        public string description;

        public Room north = null;
        public Room south = null;
        public Room east = null;
        public Room west = null;

        public Room(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
        
        public void setNorthRoom(Room north)
        {
            north.south = this;
            this.north = north;
        }

        public void setSouthRoom(Room south)
        {
            south.north = this;
            this.south = south;
        }

        public void setEastRoom(Room east)
        {
            east.west = this;
            this.east = east;
        }

        public void setWestRoom(Room west)
        {
            west.east = this;
            this.west = west;
        }

        public void print()
        {
            Console.WriteLine();
            Console.WriteLine(title);

            Console.WriteLine("".PadLeft(title.Length, '-'));
            Console.WriteLine(description);
            Console.WriteLine("".PadLeft(title.Length, '-'));

            Console.WriteLine("Exits: {0}{1}{2}{3}\n", north != null ? "" : "North",
                                                       south != null ? "" : "South",
                                                       east != null ? "" : "East",
                                                       west != null ? "" : "West");
        }

        public void parseInputLine(string input)
        {
            bool isCorrectString = InputParser.parseAsText(input);

            while(isCorrectString)
            {
                Console.WriteLine("Did not expect this input, make sure you typed the right command");
            }

            switch(input)
            {
                case "north":
                {
                    if (north != null)
                        Game.currentRoom = north;
                    break;
                }

                case "south":
                {
                    if (south != null)
                        Game.currentRoom = south;
                    break;
                }

                case "east":
                {
                    if (east != null)
                        Game.currentRoom = east;
                    break;
                }

                case "west":
                {
                    if (west != null)
                        Game.currentRoom = west;
                    break;
                }

                default:
                {
                    Console.WriteLine("Did not expect this input, make sure you typed the right command");
                    break;
                }
            }

            if(Game.currentRoom != this)
            {
                //Game.onChangeRoom();
            }
        }
    }
}
