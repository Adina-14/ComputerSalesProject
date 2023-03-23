namespace ComputerSalesProject.Models
{
    public interface IPartsRepository
    {
        //search--> id 
        //get all products
        //sale?

        IEnumerable<Parts> GetAllParts { get; set; }
        IEnumerable<Parts> GetPartsOnSale { get; set; }

        Parts GetPartsById(int partsId);
    }
}
