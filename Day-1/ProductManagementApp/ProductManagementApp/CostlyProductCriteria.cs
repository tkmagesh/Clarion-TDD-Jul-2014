namespace ProductManagementApp
{
    public class CostlyProductCriteria : IProductCriteria
    {
        private readonly decimal _basePrice;

        public CostlyProductCriteria(decimal basePrice)
        {
            _basePrice = basePrice;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Cost > _basePrice;
        }
    }
}