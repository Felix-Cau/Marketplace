using Marketplace.Entities;
using System.Data;
using System.Data.SqlClient;
using Message = Marketplace.Entities.Message;

namespace Marketplace.Repository
{
    public static class MessageRepository
    {
        public static void Send(Message message)
        {
            string sqlQuery = "INSERT INTO Message(SenderID, ReciverID, Title, Message) VALUES (@senderID, @reciverID, @title, @messagetext";

            List<SqlParameter> parameters = new();
            parameters.Add(new SqlParameter("@senderID", message.SenderID));
            parameters.Add(new SqlParameter("@reciverID", message.ReciverID));
            parameters.Add(new SqlParameter("@title", message.Title));
            parameters.Add(new SqlParameter("@messagetext", message.MessageText));

            DbContext.ExecuteNonQuery(sqlQuery, parameters);
        }

        public static void Delete(Message message)
        {
            string sqlQuery = "DELETE FROM Message WHERE MessageID = @messageID";

            List<SqlParameter> parameters = new();
            parameters.Add(new SqlParameter("@messageID", message.MessageID));

            DbContext.ExecuteNonQuery(sqlQuery, parameters);
        }

        public static List<Message> GetMessages(Member member)
        {
            string sqlQuery = "SELECT * FROM Message WHERE ReciverID = @reciverID";

            List<SqlParameter> parameters = new();
            parameters.Add(new SqlParameter("@reciverID", member.Username));

            DataTable data = DbContext.ExecuteQueryReturnTable(sqlQuery, parameters);

            List<Message> loadedMessages = new();

            foreach (DataRow row in data.Rows)
            {
                loadedMessages.Add(new Message((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), row.ItemArray[4].ToString()));
            }

            return loadedMessages;
        }
    }
}
