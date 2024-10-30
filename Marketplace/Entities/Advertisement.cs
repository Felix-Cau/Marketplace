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
        public DateTime Date { get; private set; }
        public string Username { get; private set; }
        public int CategoryID { get; private set; }

        //Constructor to create new advertisement
        public Advertisement(string title, string description, string username, int price, int category)
        {
            Title = title;
            Description = description;
            Username = username;
            Price = price;
            CategoryID = category;
            Date = DateTime.Now;
        }

        //Constructor for mapping from DB
        public Advertisement(int advertisementID, string title, string description, string username, int price, int category, DateTime date)
        {
            AdvertisementID = advertisementID;
            Title = title;
            Description = description;
            Username = username;
            Price = price;
            CategoryID = category;
            Date = date;
        }

        public void SetAdvertisementTitle(string title) { Title = title; }

        public void SetAdvertisementDescription(string description) { Description = description; }

        public void SetAdvertisementPrice(int price) { Price = price; }

        public void SetAdvertisementCategoryID(int categoryID) { CategoryID = categoryID; }
    }
}
