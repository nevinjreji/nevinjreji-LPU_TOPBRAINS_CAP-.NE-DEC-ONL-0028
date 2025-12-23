using System;

namespace Day5Assignment
{
    public class Laptop : Computer
    {
        public int DisplaySize { get; set; }
        public int BatteryVolt { get; set; }

        //Price calculation for laptop
        public double LaptopPriceCalculation()
        {
            int processorCost = 0;

            switch (Processor)
            {
                case "i3":
                    processorCost = 2500;
                    break;
                case "i5":
                    processorCost = 5000;
                    break;
                case "i7":
                    processorCost = 6500;
                    break;
            }

            double price = processorCost + (RamSize * 200) + (HardDiskSize * 1500) + (GraphicCard * 2500) + (DisplaySize * 250) + (BatteryVolt * 20);

            return price;
        }
    }
}
