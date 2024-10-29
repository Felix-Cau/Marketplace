using Marketplace.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Repository
{
    public class AdvertisementRepository
    {
        public void Save(Advertisement advertisement)
        {
            string sqlQuery = "INSERT INTO Advertisement(Title, Description, Username, Price, CategoryID) VALUES (@title, @description, @username, @price, @categoryID)";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@title", advertisement.Title));
            parameters.Add(new SqlParameter("@description", advertisement.Description));
            parameters.Add(new SqlParameter("@username", advertisement.Username));
            parameters.Add(new SqlParameter("@price", advertisement.Price));
            parameters.Add(new SqlParameter("@categoryID", advertisement.Category));

            DbContext.ExecuteNonQuery(sqlQuery, parameters);
        }

        public List<Advertisement> GetList()
        {
            string sqlQuery = "SELECT * FROM Advertisement";

            DataTable data = DbContext.ExecuteQueryReturnTable(sqlQuery, new List<SqlParameter>());

            List<Advertisement> advertisements = new List<Advertisement>();

            foreach (DataRow row in data.Rows)
            {
                advertisements.Add(new Advertisement((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), (int)row.ItemArray[4], row.ItemArray[5].ToString()));
            }

            return advertisements;
        }

        public List<Advertisement> GetAdvertisement(string searchCategory, string searchTitle)
        {
            List<Advertisement> searchResult = new();

            string searchParameterAsLower = "%" + searchTitle.ToLower() + "%";
            string searchParameterCategory = searchCategory;

            List<SqlParameter> parameters = new();

            string sqlQuery = string.Empty;

            if (string.IsNullOrEmpty(searchCategory))
            {
                sqlQuery = "SELECT * FROM Advertisement WHERE LOWER(Title) LIKE @searchParameterAsLower";

                parameters.Add(new SqlParameter("@serachParameterAsLower", searchParameterAsLower));
            }
            else if (string.IsNullOrEmpty(searchTitle))
            {
                sqlQuery = "SELECT * FROM Advertisement WHERE CategoryID = @searchParameterCategory";

                parameters.Add(new SqlParameter("@searchParameterCategory", searchParameterCategory));
            }
            else
            {
                sqlQuery = "SELECT * FROM Advertisement WHERE (LOWER(Title) LIKE @searchParameterAsLower) AND (CategoryID = @searchParameterCategory)";

                parameters.Add(new SqlParameter("@searchParameterAsLower", searchParameterAsLower));
                parameters.Add(new SqlParameter("@searchParameterCategory", searchParameterCategory));
            }

            DataTable data = DbContext.ExecuteQueryReturnTable(sqlQuery, parameters);

            foreach (DataRow row in data.Rows)
            {
                searchResult.Add(new Advertisement((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), (int)row.ItemArray[4], row.ItemArray[5].ToString()));
            }

            return searchResult;
        }
    }
}
