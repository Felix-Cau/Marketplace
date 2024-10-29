using Marketplace.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Repository
{
    public class CategoryRepository
    {
        public List<Category> GetList()
        {
            string sqlQuery = "SELECT * FROM Category";

            DataTable data = DbContext.ExecuteQueryReturnTable(sqlQuery, new List<SqlParameter>());

            List<Category> categories = new();

            foreach (DataRow row in data.Rows)
            {
                categories.Add(new Category((int)row.ItemArray[0], row.ItemArray[1].ToString()));
            }

            return categories;
        }
    }
}
