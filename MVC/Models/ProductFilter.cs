namespace MVC.Models
{
    public class ProductFilter
    {
        public string? Term { get; set; }
        public int? MinPrice { get; set; }

        public int page { get; set; } = 1;

    }
}
