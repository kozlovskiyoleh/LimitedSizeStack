using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedSizeStack.Command_pattern
{
    public struct LastRemovedElement<TItem>
    {
        public readonly TItem Value;
        public readonly int Index;

        public LastRemovedElement(TItem value, int index)
        {
            Value = value;
            Index = index;
        }
    }
}
