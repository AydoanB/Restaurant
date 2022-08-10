using System;
using ConsoleApp1;
using RestaurantManager.Controller;
using WindowsFormsApp1.Models.Dishes;

namespace RestaurantManager.Factories
{
    public class DishFactory
    {
        public Dish Create(DishInputModel model)
        {
            Dish dish;

            if (model.Category == "Main")
            {
                dish = new Main(model.Name, model.Weight, model.Price);
            }
            else if (model.Category == "Soup")
            {
                dish = new Soup(model.Name, model.Weight, model.Price);
            }
            else if (model.Category == "Dessert")
            {
                dish = new Dessert(model.Name, model.Weight, model.Price);
            }
            else if (model.Category == "Drink")
            {
                dish = new Drink(model.Name, model.Weight, model.Price);
            }
            else if (model.Category == "Salad")
            {
                dish = new Salad(model.Name, model.Weight, model.Price);
            }
            else
            {
                throw new ArgumentException("Invalid category!");
            }

            return dish;
        }
    }
}