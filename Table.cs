using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Table
    {
        private readonly List<IDish> dishesOnTable = new List<IDish>();
        public List<IDish> DishesOnTable => dishesOnTable;
        public Table(int tableNum)
        {
            this.TableNumber = tableNum;
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
        public decimal Check { get; set; }

        public void AddDishToSpeciefiedTable(IDish dish)
        {
            dishesOnTable.Add(dish);
            Check += dish.Price;
        }


    }
}