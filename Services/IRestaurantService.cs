using System.Collections.Generic;
using ConsoleApp1;

namespace RestaurantManager.Services
{
    public interface IRestaurantService
    {
         int MakeOrder(int tableNumber, List<IDish> selectedDishes);
         Table GetByTableNumber(int tableNumber);
    }
}