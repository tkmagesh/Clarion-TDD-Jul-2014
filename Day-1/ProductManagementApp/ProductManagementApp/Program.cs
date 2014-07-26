using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new ProductsCollection();
            products.Add(new Product{Id = 6, Name = "Pen", Cost = 10, Units = 10, Category = 1});
            products.Add(new Product{Id = 4, Name = "Hen", Cost = 90, Units = 30, Category = 2});
            products.Add(new Product{Id = 9, Name = "Ten", Cost = 30, Units = 20, Category = 1});
            products.Add(new Product{Id = 2, Name = "Den", Cost = 70, Units = 50, Category = 2});
            products.Add(new Product{Id = 7, Name = "Zen", Cost = 40, Units = 30, Category = 1});
            products.Add(new Product{Id = 1, Name = "Len", Cost = 50, Units = 10, Category = 2});

            Console.WriteLine("Initial List....");
            Console.WriteLine("========================================================");
            foreach(var product in products)
                Console.WriteLine(product);
            Console.WriteLine("========================================================");
            Console.WriteLine();

            Console.WriteLine("After Sort....");
            Console.WriteLine("========================================================");
            products.Sort(new CompareProductById());
            foreach (var product in products)
                Console.WriteLine(product);
            Console.WriteLine("========================================================");
            Console.WriteLine();

            Console.WriteLine("After Sort by cost....");
            Console.WriteLine("========================================================");
            products.Sort(new CompareProductByCost());
            foreach (var product in products)
                Console.WriteLine(product);
            Console.WriteLine("========================================================");
            Console.WriteLine();

            Console.WriteLine("After Sort by units....");
            Console.WriteLine("========================================================");
            products.Sort(new CompareProductByUnits());
            foreach (var product in products)
                Console.WriteLine(product);
            Console.WriteLine("========================================================");
            Console.WriteLine();

            Console.WriteLine("All costly products (cost > 50)....");
            Console.WriteLine("========================================================");
            var costlyProducts = products.Filter(new CostlyProductCriteria(50));
            foreach (var product in costlyProducts)
                Console.WriteLine(product);
            Console.WriteLine("========================================================");
            Console.WriteLine();

            Console.WriteLine("All products belonging to category 1");
            Console.WriteLine("========================================================");
            var cat1Products = products.Filter(new CategoryCriteria(1));
            foreach (var product in cat1Products)
                Console.WriteLine(product);
            Console.WriteLine("========================================================");
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    public class CompareProductByUnits : ICompareProduct
    {
        public bool ShouldSwap(Product leftProduct, Product rightProduct)
        {
            return leftProduct.Units > rightProduct.Units;
        }
    }

}
