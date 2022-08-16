using System.Collections.Generic;
using ConsoleApp1;
using RestaurantManager.Controller;

namespace RestaurantManager.Services
{
    public interface IMenuService
    {
        void CreateDish(DishInputModel model);

        string GetForMenuList();
    }
}