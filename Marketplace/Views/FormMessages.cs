using Marketplace.Entities;
using Marketplace.Helper_classes;
using Marketplace.Repository;
using Message = Marketplace.Entities.Message;

namespace Marketplace.Views
{
    public partial class FormMessages : Form
    {
        Member activeMember = null;
        Message currentMessage = null;
        Advertisement currentAdvertisement = null;
        List<Message> recievedMessages = new();

        public FormMessages(Member member)
        {
            activeMember = member;
            InitializeComponent();
            LoadMessageTypes();
            LoadMessages();
        }

        public FormMessages(Member member, Advertisement advertisement)
        {
            activeMember = member;
            currentAdvertisement = advertisement;
            InitializeComponent();
            LoadMessageTypes();
            LoadMessages();

            textBoxRecipient.Text = advertisement.Username;
            textBoxSenderID.Text = activeMember.Username;
            textBoxTopic.Text = $"Angående {advertisement.Title}";
            richTextBoxMessageText.Text = $"\n\n\n\n\n----------------------\nSkriv ditt meddalnde ovanför strecket.\nFrån annons:\n{advertisement.Description}";
            currentMessage = new(activeMember.Username, advertisement.Username, textBoxTopic.Text.Trim(), richTextBoxMessageText.Text.Trim());
        }

        private void LoadMessages()
        {
            recievedMessages = MessageRepository.GetMessages(activeMember);

            listBoxMessageList.DataSource = recievedMessages;
            listBoxMessageList.DisplayMember = "Title";
            listBoxMessageList.ValueMember = "MessageID";
        }

        public void LoadMessageTypes()
        {
            ComboBoxHelper.SetComboBoxDataSourceForMessages(comboBoxMessageTypes);
        }

        private void listBoxMessageList_Click(object sender, EventArgs e)
        {
            int messageID = (int)listBoxMessageList.SelectedValue;

            currentMessage = recievedMessages.SingleOrDefault(x => x.MessageID == messageID);

            textBoxSenderID.Text = currentMessage.SenderID.ToString();
            textBoxRecipient.Text = currentMessage.ReciverID.ToString();
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
            if (currentMessage is null)
            {
                Message newMessage = new(activeMember.Username, currentAdvertisement.Username, textBoxTopic.Text.Trim(), richTextBoxMessageText.Text.Trim());

                MessageRepository.Send(newMessage);
            }
            else
            {
                currentMessage = new(activeMember.Username, currentMessage.ReciverID, textBoxTopic.Text.Trim(), richTextBoxMessageText.Text.Trim());

                MessageRepository.Send(currentMessage);
            }
            MessageBox.Show("Meddelandet skickat.");

            buttonClearFields_Click(sender, e);
        }

        private void comboBoxMessageTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string whatMessagesToDisplayOption = comboBoxMessageTypes.SelectedValue.ToString();

            switch (whatMessagesToDisplayOption)
            {
                case "Recieved":
                    LoadMessages();
                    break;
                case "Send":
                    recievedMessages = MessageRepository.GetSendMessages(activeMember);

                    listBoxMessageList.DataSource = recievedMessages;
                    listBoxMessageList.DisplayMember = "Title";
                    listBoxMessageList.ValueMember = "MessageID";
                    break;
                default:
                    break;
            }
        }
    }
}
