using ConsoleApp1;

namespace WindowsFormsApp1.Models.Dishes
{
    public class Dish : IDish
    {
        //private string[] possibleDishCategories = { "salad", "soup", "main", "dessert", "drink" };

        public string Name { get; set; }

        public string Category { get; set; }

        public double Weight { get; set; }

        public decimal Price { get; set; }

        public virtual double Calories { get; set; }


        public override string ToString()
        {
            return $"[{this.GetType().Name}]: {this.Name} {this.Price} lv.";
        }
    }
}