namespace ProductManagementApp
{
    public interface IProductCriteria
    {
        bool IsSatisfied(Product product);
    }
}