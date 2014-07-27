namespace ProductManagementApp
{
    public class CompareProductById : ICompareProduct
    {
        public bool ShouldSwap(Product leftProduct, Product rightProduct)
        {
            return leftProduct.Id > rightProduct.Id;
        }
    }
}