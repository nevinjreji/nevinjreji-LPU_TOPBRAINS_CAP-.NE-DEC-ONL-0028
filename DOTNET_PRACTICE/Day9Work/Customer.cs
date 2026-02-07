using System;
using System.Collections.Generic;

namespace Day9Work
{
    class Customer
    {
        private List<Orders> orderList;

        public Customer()
        {
            myOrders = new List<Orders>();
            BillingAddr = new Address();
            ShippingAddr = new Address();
        }

        public int CustID { get; set; }
        public string Name { get; set; }
        public Address BillingAddr { get; set; }
        public Address ShippingAddr { get; set; }

        public List<Orders> MyOrders
        {
            get
            {
                return orderList;
            }
            set
            {
                
            }
        }
    }
}
