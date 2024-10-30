namespace Marketplace
{
    partial class FormKlumpen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogin = new Button();
            buttonCreateNewMember = new Button();
            buttonSearch = new Button();
            comboBoxSearchCategory = new ComboBox();
            textBoxSearchField = new TextBox();
            label1 = new Label();
            listBoxSearchResult = new ListBox();
            label2 = new Label();
            textBoxTitle = new TextBox();
            richTextBoxDescription = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxPrice = new TextBox();
            comboBoxAdvertisementCategory = new ComboBox();
            label6 = new Label();
            buttonClearFields = new Button();
            comboBoxSortSearchResults = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(586, 8);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Logga in";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCreateNewMember
            // 
            buttonCreateNewMember.Location = new Point(529, 37);
            buttonCreateNewMember.Name = "buttonCreateNewMember";
            buttonCreateNewMember.Size = new Size(132, 23);
            buttonCreateNewMember.TabIndex = 1;
            buttonCreateNewMember.Text = "Skapa ny användare";
            buttonCreateNewMember.UseVisualStyleBackColor = true;
            buttonCreateNewMember.Click += buttonCreateNewMember_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(357, 26);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // comboBoxSearchCategory
            // 
            comboBoxSearchCategory.FormattingEnabled = true;
            comboBoxSearchCategory.Location = new Point(12, 26);
            comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            comboBoxSearchCategory.Size = new Size(157, 23);
            comboBoxSearchCategory.TabIndex = 3;
            // 
            // textBoxSearchField
            // 
            textBoxSearchField.Location = new Point(175, 26);
            textBoxSearchField.Name = "textBoxSearchField";
            textBoxSearchField.Size = new Size(176, 23);
            textBoxSearchField.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Kategori";
            // 
            // listBoxSearchResult
            // 
            listBoxSearchResult.FormattingEnabled = true;
            listBoxSearchResult.ItemHeight = 15;
            listBoxSearchResult.Location = new Point(12, 130);
            listBoxSearchResult.Name = "listBoxSearchResult";
            listBoxSearchResult.Size = new Size(157, 454);
            listBoxSearchResult.TabIndex = 6;
            listBoxSearchResult.Click += listBoxSearchResult_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 7;
            label2.Text = "Sökresultat";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(175, 130);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(176, 23);
            textBoxTitle.TabIndex = 8;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(175, 174);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(486, 410);
            richTextBoxDescription.TabIndex = 9;
            richTextBoxDescription.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 112);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 10;
            label3.Text = "Titel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 156);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 11;
            label4.Text = "Beskrivning";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 112);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 12;
            label5.Text = "Pris";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(357, 130);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 13;
            // 
            // comboBoxAdvertisementCategory
            // 
            comboBoxAdvertisementCategory.FormattingEnabled = true;
            comboBoxAdvertisementCategory.Location = new Point(463, 130);
            comboBoxAdvertisementCategory.Name = "comboBoxAdvertisementCategory";
            comboBoxAdvertisementCategory.Size = new Size(198, 23);
            comboBoxAdvertisementCategory.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 112);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 15;
            label6.Text = "Annonskategori";
            // 
            // buttonClearFields
            // 
            buttonClearFields.Location = new Point(586, 590);
            buttonClearFields.Name = "buttonClearFields";
            buttonClearFields.Size = new Size(75, 23);
            buttonClearFields.TabIndex = 16;
            buttonClearFields.Text = "Töm fälten";
            buttonClearFields.UseVisualStyleBackColor = true;
            buttonClearFields.Click += buttonClearFields_Click;
            // 
            // comboBoxSortSearchResults
            // 
            comboBoxSortSearchResults.FormattingEnabled = true;
            comboBoxSortSearchResults.Location = new Point(12, 86);
            comboBoxSortSearchResults.Name = "comboBoxSortSearchResults";
            comboBoxSortSearchResults.Size = new Size(157, 23);
            comboBoxSortSearchResults.TabIndex = 17;
            comboBoxSortSearchResults.SelectedIndexChanged += comboBoxSortSearchResults_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 68);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 18;
            label7.Text = "Sortera resultat";
            // 
            // FormKlumpen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 661);
            Controls.Add(label7);
            Controls.Add(comboBoxSortSearchResults);
            Controls.Add(buttonClearFields);
            Controls.Add(label6);
            Controls.Add(comboBoxAdvertisementCategory);
            Controls.Add(textBoxPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(richTextBoxDescription);
            Controls.Add(textBoxTitle);
            Controls.Add(label2);
            Controls.Add(listBoxSearchResult);
            Controls.Add(label1);
            Controls.Add(textBoxSearchField);
            Controls.Add(comboBoxSearchCategory);
            Controls.Add(buttonSearch);
            Controls.Add(buttonCreateNewMember);
            Controls.Add(buttonLogin);
            Name = "FormKlumpen";
            Text = "Klumpen Marketplace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Button buttonCreateNewMember;
        private Button buttonSearch;
        private ComboBox comboBoxSearchCategory;
        private TextBox textBoxSearchField;
        private Label label1;
        private ListBox listBoxSearchResult;
        private Label label2;
        private TextBox textBoxTitle;
        private RichTextBox richTextBoxDescription;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxPrice;
        private ComboBox comboBoxAdvertisementCategory;
        private Label label6;
        private Button buttonClearFields;
        private ComboBox comboBoxSortSearchResults;
        private Label label7;
    }
}
