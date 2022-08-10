using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Table
    {
        private readonly List<IDish> dishesOnTable;

        public Table(int tableNumber, List<IDish> dishesOnTable)
        {
            this.dishesOnTable = dishesOnTable;
            this.TableNumber = tableNumber;
        }

        public int TableNumber { get; set; }

        public decimal Check => this.dishesOnTable.Sum(d => d.Price);

        public void AddDishes(List<IDish> orderedDishes)
        {
            this.dishesOnTable.AddRange(orderedDishes);
        }

        public List<IDish> GetAll()
        {
            return this.dishesOnTable;
        }
    }
}