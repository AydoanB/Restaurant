using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Table
    {
        private readonly List<IDish> dishesOnTable;
        public List<IDish> DishesOnTable => dishesOnTable;
        public Table(int tableNum)
        {
            this.TableNumber = tableNum;
            dishesOnTable = new List<IDish>();
        }
        private int tableNumber;
        public int TableNumber
        {
            get { return tableNumber; }
            set
            {
                if (value < 1 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Възможни номера от 1 до 20 / Possible numbers between 1 and 20");
                }
                tableNumber = value;
            }
        }

        public decimal Check => this.dishesOnTable.Sum(d => d.Price);
        public double Calories => this.dishesOnTable.Sum(d => d.Calories);




    }
}