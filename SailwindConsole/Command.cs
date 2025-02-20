﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailwindConsole
{
    public abstract class Command
    {
        public abstract string Name { get; }
        public virtual string[] Aliases { get; } = new string[0];
        public virtual string Usage { get; }
        public abstract string Description { get; }

        public virtual int MinArgs { get; } = 0;

        public abstract void OnRun(List<string> args);
    }
}
