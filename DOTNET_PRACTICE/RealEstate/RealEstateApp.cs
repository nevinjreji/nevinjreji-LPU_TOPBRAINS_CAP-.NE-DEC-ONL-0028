using System.Collections.Generic;
namespace RealEstate
{
    class RealEstateApp
    {
        private List<RealEstateListing> listings = new List<RealEstateListing>();

        public void AddListing(RealEstateListing listing)
        {
            listings.Add(listing);
        }
        public void RemoveListing(int listingID)
        {
            RealEstateListing itemToRemove = null;

            foreach (var item in listings)
            {
                if (listingID == item.ID)
                {
                    itemToRemove = item;
                    break;
                }
            }

            if (itemToRemove != null)
            {
                listings.Remove(itemToRemove);
            }
            else
            {
                System.Console.WriteLine($"No Listing with {listingID} found.");
            }
        }

        public void UpdateListing(RealEstateListing listing)
        {
            var updateListId = listing.ID;
            bool flag = false;

            foreach (var item in listings)
            {
                if (item.ID == updateListId)
                {
                    item.Title = listing.Title;
                    item.Description = listing.Description;
                    item.Price = listing.Price;
                    item.Location = listing.Location;
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                System.Console.WriteLine($"Listing with {updateListId} not found");
            }

        }
        public List<RealEstateListing> GetAllListings()
        {
            return listings;
        }
        public List<RealEstateListing> GetListingsByLocation(string location)
        {
            List<RealEstateListing> listings2 = new List<RealEstateListing>();

            foreach (var item in listings)
            {
                if(item.Location == location)
                {
                    listings2.Add(item);
                }
            }
            return listings2;
        }
        public List<RealEstateListing> GetListingsByPriceRange(int minPrice, int maxPrice)
        {
            List<RealEstateListing> listing3 = new List <RealEstateListing>();

            foreach (var item in listings)
            {
                if(item.Price >= minPrice && item.Price <= maxPrice)
                {
                    listing3.Add(item);
                }
            }
            return listing3;
        }
    }
}