using ConsoleApp1;

namespace WindowsFormsApp1.Controller
{
    public class MenuController
    {

        public IDish AddDishToTheMenu(string category, string name, double weight, decimal price)
        {
            IDish dish = new Dish(category, name, weight, price);
            Menu.Dishes.Add(dish);
            return dish;
        }
    }
}