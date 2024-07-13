using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedSizeStack.Command_pattern
{
    public class Receiver<TItem>
    {
        public readonly List<TItem> _items = new List<TItem>();

        public void AddItem(TItem item) => _items.Add(item);
        public void RemoveItem(int index) => _items.RemoveAt(index);
    }
}
