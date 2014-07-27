namespace ProductManagementApp
{
    public class CompareProductByCost : ICompareProduct
    {
        public bool ShouldSwap(Product leftProduct, Product rightProduct)
        {
            return leftProduct.Cost > rightProduct.Cost;
        }
    }
}