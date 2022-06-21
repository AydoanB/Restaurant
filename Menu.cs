using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ConsoleApp1
{
    public class Menu
    {
        private List<IDish> dishes = new List<IDish>();


        public List<IDish> Dishes
        {
            get { return dishes; }
            private set { Dishes = value; }
        }

        public void AddDish(IDish dish)
        {
            dishes.Add(dish);
        }
    }
}