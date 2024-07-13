using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedSizeStack
{
    public abstract class Command<TItem>
    {
        public abstract void Execute();
    }
}
