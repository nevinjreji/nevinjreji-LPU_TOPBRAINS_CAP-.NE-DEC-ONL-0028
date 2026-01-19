using System;
namespace ProductInventoryManagement
{
    interface IProduct
    {
        public string Name{ get; set; }
        public string Category{ get; set; }
        public int Stock{ get; set; }
        public int Price{ get; set; }
    }
}