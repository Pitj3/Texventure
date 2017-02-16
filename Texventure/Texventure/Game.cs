using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texventure
{
    public class Game : InputListener
    {
        public Game()
        {

        }

        public bool isRunning() { return m_Running; }

        public static Panel currentPanel = null;
        public static Room currentRoom = null;
        public string gameName = "";
        public uint width, height;

        public virtual void initialize(uint width, uint height, string title)
        {
            this.width = width;
            this.height = height;
            this.gameName = title;
        }
        public virtual void run() { m_Running = true; }
        public virtual void close() { m_Running = false; }

        //protected virtual void internalOnChangeRoom() { }

        //public static void onChangeRoom() { internalOnChangeRoom(); }

        public virtual void parseInputLine(string input)
        {
            throw new NotImplementedException();
        }

        private bool m_Running = false;
    }
}
