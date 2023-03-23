namespace ComputerSalesProject.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get;}
    }
    
}

