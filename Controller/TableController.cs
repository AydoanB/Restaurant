using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1;

namespace WindowsFormsApp1.Controller
{
    public class TableController
    {
        public void AddDishToTheTable(List<IDish> dishes, int number)
        {
            Table table = Restaurant.Tables.FirstOrDefault(t => t.TableNumber == number);
            if (table == null)
            {
                table = new Table(number);
            }
            table.DishesOnTable.AddRange(dishes);
        }

    }
}