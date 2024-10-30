namespace Marketplace.Entities
{
    public class Category
    {
        public int CategoryID { get; private set; }
        public string CategoryName { get; private set; }

        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }
        
        public Category(int categoryID, string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }
    }
}
