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

        public Panel currentPanel = null;

        public virtual void initialize(uint width, uint height, string title) { }
        public virtual void run() { m_Running = true; }
        public virtual void close() { m_Running = false; }

        public virtual void parseInputLine(string input)
        {
            throw new NotImplementedException();
        }

        private bool m_Running = false;
    }
}
