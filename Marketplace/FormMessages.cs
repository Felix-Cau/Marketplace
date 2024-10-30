using Marketplace.Entities;
using Marketplace.Repository;
using Message = Marketplace.Entities.Message;

namespace Marketplace
{
    public partial class FormMessages : Form
    {
        Member activeMember = null;
        Message currentMessage = null;

        public FormMessages(Member member)
        {
            InitializeComponent();
            LoadMessages();
        }

        public FormMessages(Member member, Advertisement advertisement)
        {
            InitializeComponent();
            LoadMessages();

            activeMember = member;
            textBoxTopic.Text = $"Angående {advertisement.Title}";
            richTextBoxMessageText.Text = $"Skriv ditt meddalnde ovanför strecket.\n----------------------\nFrån annons:\n{advertisement.Description}";
            currentMessage.SetSenderID(advertisement.Username);
        }

        List<Message> recievedMessages = new();

        private void LoadMessages()
        {
            recievedMessages = MessageRepository.GetMessages(activeMember);

            listBoxMessageList.DataSource = recievedMessages;
            listBoxMessageList.DisplayMember = "Title";
            listBoxMessageList.ValueMember = "MessageID";
        }

        private void listBoxMessageList_Click(object sender, EventArgs e)
        {
            int messageID = (int)listBoxMessageList.SelectedValue;

            currentMessage = recievedMessages.SingleOrDefault(x => x.MessageID == messageID);

            textBoxSenderID.Text = currentMessage.SenderID.ToString();
            textBoxTopic.Text = currentMessage.Title;
            textBoxRecievedDate.Text = currentMessage.Date.ToString();
            richTextBoxMessageText.Text = currentMessage.MessageText;
        }

        private void buttonRemoveMessage_Click(object sender, EventArgs e)
        {
            MessageRepository.Delete(currentMessage);

            MessageBox.Show("Meddelandet raderat.");

            buttonClearFields_Click(sender, e);
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxSenderID.Text = string.Empty;
            textBoxTopic.Text = string.Empty;
            richTextBoxMessageText.Text = string.Empty;
            textBoxRecievedDate.Text = string.Empty;

            LoadMessages();
        }

        private void buttonReply_Click(object sender, EventArgs e)
        {
            Message newMessage = new(activeMember.Username, currentMessage.SenderID, textBoxTopic.Text.Trim(), richTextBoxMessageText.Text.Trim());

            MessageRepository.Send(newMessage);

            MessageBox.Show("Meddelandet skickat.");

            buttonClearFields_Click(sender, e);
        }
    }
}
