using System;
using Day5Assignment;

class Program
{
    public static void Main(string[] args)
    {
        //Taking inputs
        Console.WriteLine("1.Desktop");
        Console.WriteLine("2.Laptop");
        Console.WriteLine("Choose the option");
        int choice = Int32.Parse(Console.ReadLine()!);

        // switch statement for desktop and laptop
        if (choice == 1)
        {
            Desktop desktop = new Desktop();

            Console.WriteLine("Enter the processor");
            desktop.Processor = Console.ReadLine()!;

            Console.WriteLine("Enter the ram size");
            desktop.RamSize = Int32.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the hard disk size");
            desktop.HardDiskSize = Int32.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the graphic card size");
            desktop.GraphicCard = Int32.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the monitor size");
            desktop.MonitorSize = Int32.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the power supply volt");
            desktop.PowerSupplyVolt = Int32.Parse(Console.ReadLine()!);

            double price = desktop.DesktopPriceCalculation();
            Console.WriteLine("Desktop price is " + price);
        }
        else if (choice == 2)
        {
            Laptop laptop = new Laptop();

            Console.WriteLine("Enter the processor");
            laptop.Processor = Console.ReadLine()!;

            Console.WriteLine("Enter the ram size");
            laptop.RamSize = Int32.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the hard disk size");
            laptop.HardDiskSize = Int32.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the graphic card size");
            laptop.GraphicCard = Int32.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the display size");
            laptop.DisplaySize = Int32.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the battery volt");
            laptop.BatteryVolt = Int32.Parse(Console.ReadLine()!);

            double price = laptop.LaptopPriceCalculation();
            Console.WriteLine("Laptop price is " + price);
        }
    }
}
