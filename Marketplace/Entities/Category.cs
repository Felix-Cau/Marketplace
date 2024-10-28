using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
