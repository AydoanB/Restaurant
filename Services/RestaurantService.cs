using System.Collections.Generic;
using System.Linq;
using ConsoleApp1;
using WindowsFormsApp1.Models.Dishes;

namespace RestaurantManager.Services
{
    public class RestaurantService : IRestaurantService
    {
        public Restaurant Restaurant => new Restaurant();

        public int MakeOrder(int tableNumber, List<IDish> selectedDishes)
        {
            var table = Restaurant.Tables.FirstOrDefault(x => x.TableNumber == tableNumber);

            if (table == null)
            {
                table = new Table(tableNumber, selectedDishes);

                Restaurant.Tables.Add(table);
            }

            table.AddDishes(selectedDishes);


            return tableNumber;
        }

        public Table GetByTableNumber(int tableNumber)
        {
            return Restaurant.Tables.FirstOrDefault(x => x.TableNumber == tableNumber);
        }
    }
}