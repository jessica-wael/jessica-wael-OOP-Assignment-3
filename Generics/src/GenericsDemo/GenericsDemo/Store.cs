using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    public class Store<T> where T : IHasId
    {
      
      private readonly Dictionary<int, T> _items = new();

        public void Add(T item)
        {
            if (_items.ContainsKey(item.Id))
                throw new ArgumentException($"An item with Id {item.Id} already exists.");


            _items.Add(item.Id, item);

        }

        public T? GetById(int id)
        {
            _items.TryGetValue(id, out var item);
            return item;

        }
        public IReadOnlyCollection<T> GetAll()
        {
            return _items.Values.ToList();
        }
        public bool Remove(int id)
        {
            return _items.Remove(id);
        }

    }
}

