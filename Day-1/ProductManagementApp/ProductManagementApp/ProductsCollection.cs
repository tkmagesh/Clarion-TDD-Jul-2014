using System.Collections;

namespace ProductManagementApp
{
    public class ProductsCollection : IEnumerable, IEnumerator
    {
        private ArrayList _list = new ArrayList();
        public void Add(Product product)
        {
            _list.Add(product);
        }
        public int Count
        {
            get { return _list.Count; }
        }

        public Product this[int index]
        {
            get { return (Product) _list[index]; }
        }

        public Product Get(int index)
        {
            return (Product) _list[index];

        }
        /*IEnumeable's Members*/
        public IEnumerator GetEnumerator()
        {
            return this;
        }


        /*IEnumerator's Members*/
        private int index = -1;
        public bool MoveNext()
        {
            ++index;
            if (index >= _list.Count)
            {
                Reset();
                return false;
            }
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get { return _list[index]; }
        }

        public void Sort(ICompareProduct comparer)
        {
            for(var i=0;i<_list.Count-1;i++)
                for (var j = i + 1; j < _list.Count; j++)
                {
                    var leftProduct = (Product) _list[i];
                    var rightProduct = (Product)_list[j];
                    var shouldSwap = comparer.ShouldSwap(leftProduct,rightProduct);
                    
                    if (shouldSwap)
                    {
                        var temp = leftProduct;
                        _list[i] =_list[j];
                        _list[j] = temp;
                    }
                }
        }

        public ProductsCollection Filter(IProductCriteria criteria)
        {
            var result = new ProductsCollection();
            foreach(var item in _list)
            {
                var product = (Product) item;
                if (criteria.IsSatisfied(product))
                    result.Add(product);
            }
            return result;
        }

        public ProductsCollection Filter(ProductCriteriaDelegate productCriteria)
        {
            var result = new ProductsCollection();
            foreach (var item in _list)
            {
                var product = (Product)item;
                if (productCriteria(product))
                    result.Add(product);
            }
            return result;
        }
    }
}