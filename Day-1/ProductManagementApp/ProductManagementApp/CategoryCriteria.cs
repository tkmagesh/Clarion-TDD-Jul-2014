namespace ProductManagementApp
{
    public class CategoryCriteria : IProductCriteria
    {
        private readonly int _category;

        public CategoryCriteria(int category)
        {
            _category = category;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Category == _category;
        }
    }
}