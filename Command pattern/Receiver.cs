using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedSizeStack.Command_pattern
{
    public class Receiver<TItem>
    {
        private readonly List<TItem> _items = new List<TItem>();
        public int LastElementIndex { get => _items.Count; }

        public void AddItem(TItem item) => _items.Add(item);
        public void RemoveItem(int index) => _items.RemoveAt(index);
        public TItem GetItem(int index) => _items.ElementAt(index);
        public void Insert(TItem element, int index) => _items.Insert(index, element);
    }
}
