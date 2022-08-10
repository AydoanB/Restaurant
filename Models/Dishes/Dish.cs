using ConsoleApp1;

namespace WindowsFormsApp1.Models.Dishes
{
    public abstract class Dish : IDish
    {
        protected Dish(string name, double weight, decimal price)
        {
            Name = name;
            Weight = weight;
            Price = price;
        }

        public string Name { get; set; }

        public double Weight { get; set; }

        public decimal Price { get; set; }

        public virtual double Calories { get; set; }


        public override string ToString()
        {
            return $"[{this.GetType().Name}]: {this.Name} {this.Price} lv.";
        }
    }
}