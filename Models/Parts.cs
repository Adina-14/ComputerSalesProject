namespace ComputerSalesProject.Models
{
    public class Parts
    {
        public int PartsId { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }

        //link to categories
        public Category Category { get; set; }

    }
}
