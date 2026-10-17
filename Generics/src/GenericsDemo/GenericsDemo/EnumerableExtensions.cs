using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenericsDemo
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Page<T>(this IEnumerable<T> source , int pageNumber, int pageSize)
        {
            if(pageNumber <1 || pageSize < 1)
            {
                throw new ArgumentException("Page number and page size must be 1 or more");
            }
          
            int start = (pageNumber - 1) * pageSize;
            int index = 0, taken = 0; 

            foreach(var item in source)
            {
                if(index >=start )
                {
                    if (taken == pageSize)
                    {
                        yield break;
                    }
                    yield return item;
                    taken++;
                }
                    index++;
            }

        }

        public static T? FindById<T>(this IEnumerable<T> source ,int id) where T : IHasId
        {
            foreach (var item in source)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return default;
        }

        public static IReadOnlyDictionary<int , T> ToIdDictionary<T>(this IEnumerable<T> source) where T : IHasId
        {
            var result = new Dictionary<int, T>();
            foreach(var item in source)
            {
                result.Add(item.Id , item); 
            }
            return result;
        }
    }
}
