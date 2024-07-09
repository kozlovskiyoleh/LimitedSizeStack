﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedSizeStack.Command_pattern
{
    public interface ICommand
    {
        void Undo();
        bool CanUndo();
    }
}
