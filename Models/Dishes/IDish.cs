namespace ConsoleApp1
{
    public interface IDish
    {
        string Category { get; set; }
        
        string Name { get; set; }
         
         double Weight { get; set; }
         
         decimal Price { get; set; }
        
         double Calories {  get;  set; }

    }
}