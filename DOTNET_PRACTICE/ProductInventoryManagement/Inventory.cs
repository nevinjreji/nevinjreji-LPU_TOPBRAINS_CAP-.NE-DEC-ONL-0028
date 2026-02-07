using System;
using System.Collections.Generic;

namespace ProductInventoryManagement
{
    class Inventory : IInventory
    {
        List<IProduct> prodlist = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            prodlist.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            string toRemove = product.Name;

            IProduct? found = null;

            foreach (var item in prodlist)
            {
                if (item.Name == toRemove)
                {
                    found = item;
                    break;
                }
            }

            if (found != null)
            {
                prodlist.Remove(found);
                Console.WriteLine("Product removed successfully");
            }
            else
            {
                Console.WriteLine("No such product found");
            }
        }

        public List<IProduct> GetProductsByCategory(string category)
        {
            List<IProduct> result = new List<IProduct>();

            foreach (var item in prodlist)
            {
                if (item.Category == category)
                {
                    result.Add(item);
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No items with this category found");
            }

            return result;
        }

        public List<(string, int)> GetProductsByCategoryWithCount()
        {
            return prodlist.GroupBy(p => p.Category)
                            .Select(g => (g.Key, g.Count()))
                            .ToList();

        }
        public List<IProduct> SearchProductsByName(string name)
        {
            string nametofound = name;
            List<IProduct> productbyname = new List<IProduct>();

            foreach (var item in prodlist)
            {
                if(item.Name == nametofound)
                {
                    productbyname.Add(item);
                }
            }
            return productbyname;
        }
        public List<(string, List<IProduct>)> GetAllProductsByCategory()
        {
            return prodlist.GroupBy(p => p.Category)
                           .Select(g => (g.Key,g.ToList()))
                           .ToList();
        }
    }
}
