﻿using WindowsFormsApp1.Models.Dishes;

namespace ConsoleApp1
{
    public class Drink : Dish
    {
        public Drink(string name, double weight, decimal price) : base(name, weight, price)
        {
        }

        public override double Calories => this.Weight * 1.5;
    }
}