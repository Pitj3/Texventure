﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texventure
{
    public abstract class Panel
    {
        public string name;
        public uint id;

        public abstract void render(int flags);
    }
}
