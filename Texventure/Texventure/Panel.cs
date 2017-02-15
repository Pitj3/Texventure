using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texventure
{
    public class Panel
    {
        public string name;
        public uint id;

        public virtual void render() { }
    }
}
