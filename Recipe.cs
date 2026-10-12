namespace BootstrapApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public int CookingTime { get; set; } // в минутах
        public int Difficulty { get; set; }  // от 1 до 5
        public string Description { get; set; }
    }
}
