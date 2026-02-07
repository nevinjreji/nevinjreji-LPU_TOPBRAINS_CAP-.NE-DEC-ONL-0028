using System;
namespace ProductInventoryManagement
{
    interface IInventory
    {
        public void AddProduct(IProduct product);
        public void RemoveProduct(IProduct product);
        public List<IProduct> GetProductsByCategory(string category);
        public List<(string,int)> GetProductsByCategoryWithCount();
        public List<IProduct> SearchProductsByName(string name);
        public List<(string,List<IProduct>)> GetAllProductsByCategory();
    }
}