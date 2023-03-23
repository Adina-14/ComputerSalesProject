namespace ComputerSalesProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        //link of parts
        public List<Parts> Partts { get; set; }
    }
}
