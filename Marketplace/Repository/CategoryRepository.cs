using Marketplace.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Marketplace.Repository
{
    public static class CategoryRepository
    {
        public static List<Category> GetList()
        {
            string sqlQuery = "SELECT * FROM Category";

            DataTable data = DbContext.ExecuteQueryReturnTable(sqlQuery, new List<SqlParameter>());

            List<Category> categories = new();

            foreach (DataRow row in data.Rows)
            {
                categories.Add(new Category((int)row.ItemArray[0], row.ItemArray[1].ToString().Trim()));
            }

            return categories;
        }
    }
}
