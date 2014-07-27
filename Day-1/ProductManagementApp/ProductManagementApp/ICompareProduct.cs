namespace ProductManagementApp
{
    public interface ICompareProduct
    {
        bool ShouldSwap(Product leftProduct, Product rightProduct);
    }
}