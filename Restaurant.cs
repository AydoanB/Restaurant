using System.Collections.Generic;
using System.Linq;
using ConsoleApp1;

namespace WindowsFormsApp1
{
    public class Restaurant
    {
        private readonly List<Table> Tables = new List<Table>();


        public void AddTable(Table table, IDish dish)
        {
            var funcTable = Tables.FirstOrDefault(t => t.TableNumber == table.TableNumber);
            if (funcTable == null)
            {
                Tables.Add(table);
                Tables[Tables.IndexOf(table)].AddDishToSpeciefiedTable(dish);
            }
            else
            {
                funcTable.AddDishToSpeciefiedTable(dish);
            }
        }

        public List<IDish> DishesOnSpecifiedTable(int tableNum)
        {
            var t = Tables.FirstOrDefault(x => x.TableNumber == tableNum);
            return t.DishesOnTable;
        }
    }
}