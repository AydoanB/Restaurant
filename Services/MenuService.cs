using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1;
using RestaurantManager.Controller;
using RestaurantManager.Factories;

namespace RestaurantManager.Services
{
    public class MenuService : IMenuService
    {
        private readonly DishFactory factory;

        private readonly List<IDish> dishes;

        public MenuService()
        {
            this.factory = new DishFactory();
            this.dishes = new List<IDish>();
        }

        public void CreateDish(DishInputModel model)
        {
            var dish = factory.Create(model);

            this.dishes.Add(dish);
        }

        public IEnumerable<string> GetAllForMenuList()
        {
            return this.dishes.Select(x => x.ToString());
        }
    }
}