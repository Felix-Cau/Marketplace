using Marketplace.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Marketplace.Repository
{
    public static class MemberRepository
    {
        public static void Save(Member member)
        {
            string sqlQuery = "INSERT INTO Member(Username, Password, FirstName, LastName, Address, PostalCode, City, Email, PhoneNumber) VALUES (@username, @password, @firstname, @lastname, @address, @postalcode, @city, @email, @phonenumber)";

            List<SqlParameter> parameters = new();
            parameters.Add(new SqlParameter("@username", member.Username));
            parameters.Add(new SqlParameter("@password", member.Password));
            parameters.Add(new SqlParameter("@firstname", member.FirstName));
            parameters.Add(new SqlParameter("@lastname", member.LastName));
            parameters.Add(new SqlParameter("@address", member.Address));
            parameters.Add(new SqlParameter("@postalcode", member.PostalCode));
            parameters.Add(new SqlParameter("@city", member.City));
            parameters.Add(new SqlParameter("@email", member.Email));
            parameters.Add(new SqlParameter("@phonenumber", member.PhoneNumber));

            DbContext.ExecuteNonQuery(sqlQuery, parameters);
        }

        public static List<Member> GetList()
        {
            string sqlQuery = "SELECT * FROM Member";

            DataTable data = DbContext.ExecuteQueryReturnTable(sqlQuery, new List<SqlParameter>());

            List<Member> members = new();

            foreach (DataRow row in data.Rows)
            {
                members.Add(new Member(row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), 
                                       row.ItemArray[4].ToString(), (int)row.ItemArray[5], row.ItemArray[6].ToString(), row.ItemArray[7].ToString(), row.ItemArray[8].ToString()));
            }

            return members;
        }

        public static (bool, Member) CheckCredentialsForLogin(string username, string password)
        {
            bool correctMemberLogin = false;

            string searchParameterUsername = username;
            string searchParameterPassword = password;

            string sqlQuery = "SELECT * FROM Member WHERE Username = @username AND Password = @password";

            List<SqlParameter> parameters = new();
            parameters.Add(new SqlParameter("@username", username));
            parameters.Add(new SqlParameter("@password", password));

            DataTable data = DbContext.ExecuteQueryReturnTable(sqlQuery, parameters);

            List<Member> members = new();

            foreach (DataRow row in data.Rows)
            {
                members.Add(new Member(row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), 
                                       row.ItemArray[4].ToString(), (int)row.ItemArray[5], row.ItemArray[6].ToString(), row.ItemArray[7].ToString(), row.ItemArray[8].ToString()));
            }

            Member returnMember = members.Count == 1 ? members[0] : null;
            correctMemberLogin = returnMember != null;

            return (correctMemberLogin, returnMember);
            //if (members.Count > 0)
            //{
            //    Member returnMember = members.SingleOrDefault(x => x.Username == username);
            //    correctMemberLogin = true;

            //    return (correctMemberLogin, returnMember);
            //}
            //else
            //{
            //    Member returnMember = null;

            //    return (correctMemberLogin, returnMember);
            //}
        }
    }
}
