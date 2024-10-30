using Marketplace.Entities;

namespace Marketplace.Helper_classes
{
    public static class SorterHelper
    {
        public static Dictionary<string, string> SortingOptions = new()
        {
            {"Billigast", "PriceAsc"},
            {"Dyrast", "PriceDesc"},
            {"Äldst", "DateDesc"},
            {"Senaste", "DateAsc"}
        };

        public static List<Advertisement> SortAdvertisementList(string sortingOption, List<Advertisement> advertisementList)
        {
            List<Advertisement> returnList = new();

            if (advertisementList.Count > 0)
            {
                switch (sortingOption)
                {
                    case "PriceAsc":
                        var sortedAscendingPrice = advertisementList.OrderBy(x => x.Price).ToList();
                        returnList = sortedAscendingPrice;
                        break;
                    case "PriceDesc":
                        var sortedDescendingPrice = advertisementList.OrderByDescending(x => x.Price).ToList();
                        returnList = sortedDescendingPrice;
                        break;
                    case "DateDesc":
                        var sortedDescendingDate = advertisementList.OrderByDescending(x => x.Date).ToList();
                        returnList = sortedDescendingDate;
                        break;
                    case "DateAsc":
                        var sortedAscendingDate = advertisementList.OrderBy(x => x.Date).ToList();
                        returnList = sortedAscendingDate;
                        break;
                    default:
                        break;
                }
            }

            return returnList;
        }
    }
}
