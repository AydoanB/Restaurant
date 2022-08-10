using System.Collections.Generic;
using System.Linq;
using ConsoleApp1;

namespace RestaurantManager
{
    public  class Restaurant
    {
        public static ICollection<Table> Tables = new List<Table>();
    }
}