using System;
using System.Collections.Generic;
using System.Text;

namespace EKRLib
{
    public class Collection <T> where T : Item
    {
        private List<T> items;

        public void Add(T item)
            => items.Add(item);
        
        
    }
}
