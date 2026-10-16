using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    public class Store<T>
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            _items.Add(item);

        }

        public T? GetById(int id)
        {
            foreach (var t in _items)
            {
                if (t.Id == id) 
                    return t;
            }
            return null;
        }
        public List<T> GetAll()
        {
            return _items;
        }
        public bool Remove(int id)
        {
            var item = GetById(id);
            if (item == null)
            {
                return false;
            }

            return _items.Remove(item);
        }
    }
}

