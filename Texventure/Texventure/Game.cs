using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texventure
{
    public abstract class Game : InputListener
    {
        public Game()
        {

        }

        public bool isRunning() { return m_Running; }

        public static Panel currentPanel = null;
        public static Room currentRoom = null;
        public string gameName = "";
        public static uint width, height;

        public virtual void initialize(uint _width, uint _height, string title)
        {
            width = _width;
            height = _height;
            this.gameName = title;
        }
        public virtual void run() { m_Running = true; }
        public virtual void close() { m_Running = false; }

        //protected virtual void internalOnChangeRoom() { }

        //public static void onChangeRoom() { internalOnChangeRoom(); }

        public abstract void parseInputLine(string input);

        private bool m_Running = false;
    }
}
