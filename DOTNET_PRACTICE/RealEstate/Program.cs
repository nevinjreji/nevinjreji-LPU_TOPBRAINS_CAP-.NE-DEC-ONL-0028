using System;
using System.Collections.Generic;
using RealEstate;

class Program
{
    static void Main()
    {
        RealEstateApp app = new RealEstateApp();
        int choice;

        do
        {
            Console.WriteLine("\n==== Real Estate Menu ====");
            Console.WriteLine("1. Add Listings");
            Console.WriteLine("2. Remove Listing");
            Console.WriteLine("3. Update Listing");
            Console.WriteLine("4. View All Listings");
            Console.WriteLine("5. View Listings by Location");
            Console.WriteLine("6. View Listings by Price Range");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("How many listings do you want to add? ");
                    int count = Int32.Parse(Console.ReadLine());

                    for (int i = 0; i < count; i++)
                    {
                        RealEstateListing listing = new RealEstateListing();

                        Console.Write("Enter ID: ");
                        listing.ID = Int32.Parse(Console.ReadLine());

                        Console.Write("Enter Title: ");
                        listing.Title = Console.ReadLine();

                        Console.Write("Enter Description: ");
                        listing.Description = Console.ReadLine();

                        Console.Write("Enter Price: ");
                        listing.Price = Int32.Parse(Console.ReadLine());

                        Console.Write("Enter Location: ");
                        listing.Location = Console.ReadLine();

                        app.AddListing(listing);
                    }
                    break;

                case 2:
                    Console.Write("Enter Listing ID to remove: ");
                    int removeId = Int32.Parse(Console.ReadLine());
                    app.RemoveListing(removeId);
                    break;

                case 3:
                    RealEstateListing updateListing = new RealEstateListing();

                    Console.Write("Enter Listing ID to update: ");
                    updateListing.ID = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter New Title: ");
                    updateListing.Title = Console.ReadLine();

                    Console.Write("Enter New Description: ");
                    updateListing.Description = Console.ReadLine();

                    Console.Write("Enter New Price: ");
                    updateListing.Price = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter New Location: ");
                    updateListing.Location = Console.ReadLine();

                    app.UpdateListing(updateListing);
                    break;

                case 4:
                    List<RealEstateListing> allListings = app.GetAllListings();
                    foreach (var item in allListings)
                    {
                        PrintListing(item);
                    }
                    break;

                case 5:
                    Console.Write("Enter Location: ");
                    string location = Console.ReadLine();
                    var locationListings = app.GetListingsByLocation(location);

                    foreach (var item in locationListings)
                    {
                        PrintListing(item);
                    }
                    break;

                case 6:
                    Console.Write("Enter Minimum Price: ");
                    int min = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Maximum Price: ");
                    int max = Int32.Parse(Console.ReadLine());

                    var priceListings = app.GetListingsByPriceRange(min, max);

                    foreach (var item in priceListings)
                    {
                        PrintListing(item);
                    }
                    break;

                case 0:
                    Console.WriteLine("Exiting application...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 0);
    }

    static void PrintListing(RealEstateListing item)
    {
        Console.WriteLine("\n------------------------");
        Console.WriteLine($"ID: {item.ID}");
        Console.WriteLine($"Title: {item.Title}");
        Console.WriteLine($"Description: {item.Description}");
        Console.WriteLine($"Price: {item.Price}");
        Console.WriteLine($"Location: {item.Location}");
    }
}
