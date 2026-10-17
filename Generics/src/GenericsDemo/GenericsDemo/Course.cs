using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    public class Course : IHasId
    {

        public int Id { get; } 
       public string Title { get; }
       public decimal Price { get; }
        public Course(int id, string title, decimal price)
        {
            Id = id;
            Title = title;
            Price = price;
        }
    }
}
