using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab
{
    internal class Item
    {
        public int value = 0;
        public Item? prev = null;

        public Item(int value, Item? prev)
        {
            this.value = value;
            this.prev = prev;
        }
    }
}
