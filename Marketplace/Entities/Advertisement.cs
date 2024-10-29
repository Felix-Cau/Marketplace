using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Entities
{
    public class Advertisement
    {
        public int AdvertisementID { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Price { get; private set; }
        public string Username { get; private set; }
        public string Category { get; private set; }

        //Constructor to create new advertisement
        public Advertisement(string title, string description, string username, int price, string category)
        {
            Title = title;
            Description = description;
            Username = username;
            Price = price;
            Category = category;
        }

        //Constructor for mapping from DB
        public Advertisement(int advertisementID, string title, string description, string username, int price, string category)
        {
            AdvertisementID = advertisementID;
            Title = title;
            Description = description;
            Username = username;
            Price = price;
            Category = category;
        }
    }
}
