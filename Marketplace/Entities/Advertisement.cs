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
        public string Username { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Price { get; private set; }
        public string Category { get; private set; }

        public Advertisement(string username, string title, string description, int price, string category)
        {
            Username = username;
            Title = title;
            Description = description;
            Price = price;
            Category = category;
        }

        public Advertisement(int advertisementID, string memberID, string title, string description, int price, string category)
        {
            AdvertisementID = advertisementID;
            Username = memberID;
            Title = title;
            Description = description;
            Price = price;
            Category = category;
        }
    }
}
