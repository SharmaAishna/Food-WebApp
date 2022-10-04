namespace RazorFirstApp.Models
{
    public class BurgersModels
    {

        public string? ImageTitle { get; set; }
        public string? BurgerName { get; set; }
        public float BasePrice { get; set; } = 2;
        public float FinalPrice { get; set; }
        public bool Tomato { get; set; }
        public bool Lettuce { get; set; }
        public bool Cheese { get; set; }
        public bool Onion { get; set; }
        public bool Jalepano { get; set; }
        public bool Ham { get; set; }

    }
}
