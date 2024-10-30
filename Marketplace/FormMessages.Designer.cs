namespace Marketplace
{
    partial class FormMessages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxMessageList = new ListBox();
            labelMessageList = new Label();
            textBoxTopic = new TextBox();
            textBoxSenderID = new TextBox();
            richTextBoxMessageText = new RichTextBox();
            labelSender = new Label();
            labelTopic = new Label();
            labelMessage = new Label();
            buttonReply = new Button();
            buttonRemoveMessage = new Button();
            labelRecievedDate = new Label();
            textBoxRecievedDate = new TextBox();
            buttonClearFields = new Button();
            labelRecipient = new Label();
            textBoxRecipient = new TextBox();
            comboBoxMessageTypes = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxMessageList
            // 
            listBoxMessageList.FormattingEnabled = true;
            listBoxMessageList.ItemHeight = 15;
            listBoxMessageList.Location = new Point(12, 90);
            listBoxMessageList.Name = "listBoxMessageList";
            listBoxMessageList.Size = new Size(176, 454);
            listBoxMessageList.TabIndex = 0;
            listBoxMessageList.Click += listBoxMessageList_Click;
            // 
            // labelMessageList
            // 
            labelMessageList.AutoSize = true;
            labelMessageList.Location = new Point(12, 72);
            labelMessageList.Name = "labelMessageList";
            labelMessageList.Size = new Size(94, 15);
            labelMessageList.TabIndex = 1;
            labelMessageList.Text = "Meddelandelista";
            // 
            // textBoxTopic
            // 
            textBoxTopic.Location = new Point(194, 90);
            textBoxTopic.Name = "textBoxTopic";
            textBoxTopic.Size = new Size(304, 23);
            textBoxTopic.TabIndex = 2;
            // 
            // textBoxSenderID
            // 
            textBoxSenderID.Location = new Point(194, 46);
            textBoxSenderID.Name = "textBoxSenderID";
            textBoxSenderID.Size = new Size(149, 23);
            textBoxSenderID.TabIndex = 3;
            // 
            // richTextBoxMessageText
            // 
            richTextBoxMessageText.Location = new Point(194, 134);
            richTextBoxMessageText.Name = "richTextBoxMessageText";
            richTextBoxMessageText.Size = new Size(478, 410);
            richTextBoxMessageText.TabIndex = 4;
            richTextBoxMessageText.Text = "";
            // 
            // labelSender
            // 
            labelSender.AutoSize = true;
            labelSender.Location = new Point(194, 28);
            labelSender.Name = "labelSender";
            labelSender.Size = new Size(62, 15);
            labelSender.TabIndex = 5;
            labelSender.Text = "Avsändare";
            // 
            // labelTopic
            // 
            labelTopic.AutoSize = true;
            labelTopic.Location = new Point(194, 72);
            labelTopic.Name = "labelTopic";
            labelTopic.Size = new Size(35, 15);
            labelTopic.TabIndex = 6;
            labelTopic.Text = "Topic";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(194, 116);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(312, 15);
            labelMessage.TabIndex = 7;
            labelMessage.Text = "Meddelande (skriv meddelande direkt i rutan för att svara)";
            // 
            // buttonReply
            // 
            buttonReply.Location = new Point(435, 550);
            buttonReply.Name = "buttonReply";
            buttonReply.Size = new Size(75, 23);
            buttonReply.TabIndex = 8;
            buttonReply.Text = "Svara";
            buttonReply.UseVisualStyleBackColor = true;
            buttonReply.Click += buttonReply_Click;
            // 
            // buttonRemoveMessage
            // 
            buttonRemoveMessage.Location = new Point(516, 550);
            buttonRemoveMessage.Name = "buttonRemoveMessage";
            buttonRemoveMessage.Size = new Size(75, 23);
            buttonRemoveMessage.TabIndex = 9;
            buttonRemoveMessage.Text = "Ta bort";
            buttonRemoveMessage.UseVisualStyleBackColor = true;
            buttonRemoveMessage.Click += buttonRemoveMessage_Click;
            // 
            // labelRecievedDate
            // 
            labelRecievedDate.AutoSize = true;
            labelRecievedDate.Location = new Point(516, 72);
            labelRecievedDate.Name = "labelRecievedDate";
            labelRecievedDate.Size = new Size(94, 15);
            labelRecievedDate.TabIndex = 10;
            labelRecievedDate.Text = "Mottaget datum";
            // 
            // textBoxRecievedDate
            // 
            textBoxRecievedDate.Location = new Point(516, 90);
            textBoxRecievedDate.Name = "textBoxRecievedDate";
            textBoxRecievedDate.Size = new Size(150, 23);
            textBoxRecievedDate.TabIndex = 11;
            // 
            // buttonClearFields
            // 
            buttonClearFields.Location = new Point(597, 550);
            buttonClearFields.Name = "buttonClearFields";
            buttonClearFields.Size = new Size(75, 23);
            buttonClearFields.TabIndex = 12;
            buttonClearFields.Text = "Töm fält";
            buttonClearFields.UseVisualStyleBackColor = true;
            buttonClearFields.Click += buttonClearFields_Click;
            // 
            // labelRecipient
            // 
            labelRecipient.AutoSize = true;
            labelRecipient.Location = new Point(349, 28);
            labelRecipient.Name = "labelRecipient";
            labelRecipient.Size = new Size(62, 15);
            labelRecipient.TabIndex = 14;
            labelRecipient.Text = "Mottagare";
            // 
            // textBoxRecipient
            // 
            textBoxRecipient.Location = new Point(349, 46);
            textBoxRecipient.Name = "textBoxRecipient";
            textBoxRecipient.Size = new Size(149, 23);
            textBoxRecipient.TabIndex = 13;
            // 
            // comboBoxMessageTypes
            // 
            comboBoxMessageTypes.FormattingEnabled = true;
            comboBoxMessageTypes.Location = new Point(12, 46);
            comboBoxMessageTypes.Name = "comboBoxMessageTypes";
            comboBoxMessageTypes.Size = new Size(176, 23);
            comboBoxMessageTypes.TabIndex = 15;
            comboBoxMessageTypes.SelectedIndexChanged += comboBoxMessageTypes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 16;
            label1.Text = "Visa mottagna/skickade";
            // 
            // FormMessages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 595);
            Controls.Add(label1);
            Controls.Add(comboBoxMessageTypes);
            Controls.Add(labelRecipient);
            Controls.Add(textBoxRecipient);
            Controls.Add(buttonClearFields);
            Controls.Add(textBoxRecievedDate);
            Controls.Add(labelRecievedDate);
            Controls.Add(buttonRemoveMessage);
            Controls.Add(buttonReply);
            Controls.Add(labelMessage);
            Controls.Add(labelTopic);
            Controls.Add(labelSender);
            Controls.Add(richTextBoxMessageText);
            Controls.Add(textBoxSenderID);
            Controls.Add(textBoxTopic);
            Controls.Add(labelMessageList);
            Controls.Add(listBoxMessageList);
            Name = "FormMessages";
            Text = "Meddelanden";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMessageList;
        private Label labelMessageList;
        private TextBox textBoxTopic;
        private TextBox textBoxSenderID;
        private RichTextBox richTextBoxMessageText;
        private Label labelSender;
        private Label labelTopic;
        private Label labelMessage;
        private Button buttonReply;
        private Button buttonRemoveMessage;
        private Label labelRecievedDate;
        private TextBox textBoxRecievedDate;
        private Button buttonClearFields;
        private Label labelRecipient;
        private TextBox textBoxRecipient;
        private ComboBox comboBoxMessageTypes;
        private Label label1;
    }
}