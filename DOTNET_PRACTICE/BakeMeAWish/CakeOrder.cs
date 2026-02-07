using System;
namespace BakeMeAWish
{
    public class CakeOrder
    {
        private Dictionary<String,Double> orderMap = new Dictionary<string, double>();
        // key - orderid , value - cakecost

        private Dictionary<string,Double> filteredMap = new Dictionary<string, double>();

        public void addOrderDetails(string orderId , double cakeCost)
        {
            orderMap.Add(orderId,cakeCost);
        }

        public Dictionary<string,double> findOrdersAboveSpecifiedCost(double cakeCost)
        {
            foreach(var item  in orderMap)
            {
                if(item.Value > cakeCost)
                {
                    filteredMap.Add(item.Key,item.Value);
                }
            }
            return filteredMap;
        }
    }
}