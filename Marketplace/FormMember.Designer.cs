namespace Marketplace
{
    partial class FormMember
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
            label7 = new Label();
            comboBoxSortSearchResults = new ComboBox();
            buttonClearFields = new Button();
            label6 = new Label();
            comboBoxAdvertisementCategory = new ComboBox();
            textBoxPrice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            richTextBoxDescription = new RichTextBox();
            textBoxTitle = new TextBox();
            label2 = new Label();
            listBoxSearchResult = new ListBox();
            label1 = new Label();
            textBoxSearchField = new TextBox();
            comboBoxSearchCategory = new ComboBox();
            buttonSearch = new Button();
            buttonLogOut = new Button();
            buttonLoadUserAdvertisements = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 69);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 37;
            label7.Text = "Sortera resultat";
            // 
            // comboBoxSortSearchResults
            // 
            comboBoxSortSearchResults.FormattingEnabled = true;
            comboBoxSortSearchResults.Location = new Point(12, 87);
            comboBoxSortSearchResults.Name = "comboBoxSortSearchResults";
            comboBoxSortSearchResults.Size = new Size(157, 23);
            comboBoxSortSearchResults.TabIndex = 36;
            comboBoxSortSearchResults.Click += comboBoxSortSearchResults_Click;
            // 
            // buttonClearFields
            // 
            buttonClearFields.Location = new Point(586, 591);
            buttonClearFields.Name = "buttonClearFields";
            buttonClearFields.Size = new Size(75, 23);
            buttonClearFields.TabIndex = 35;
            buttonClearFields.Text = "Töm fälten";
            buttonClearFields.UseVisualStyleBackColor = true;
            buttonClearFields.Click += buttonClearFields_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 113);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 34;
            label6.Text = "Annonskategori";
            // 
            // comboBoxAdvertisementCategory
            // 
            comboBoxAdvertisementCategory.FormattingEnabled = true;
            comboBoxAdvertisementCategory.Location = new Point(463, 131);
            comboBoxAdvertisementCategory.Name = "comboBoxAdvertisementCategory";
            comboBoxAdvertisementCategory.Size = new Size(198, 23);
            comboBoxAdvertisementCategory.TabIndex = 33;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(357, 131);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 113);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 31;
            label5.Text = "Pris";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 157);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 30;
            label4.Text = "Beskrivning";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 113);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 29;
            label3.Text = "Titel";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(175, 175);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(486, 410);
            richTextBoxDescription.TabIndex = 28;
            richTextBoxDescription.Text = "";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(175, 131);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(176, 23);
            textBoxTitle.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 26;
            label2.Text = "Sökresultat";
            // 
            // listBoxSearchResult
            // 
            listBoxSearchResult.FormattingEnabled = true;
            listBoxSearchResult.ItemHeight = 15;
            listBoxSearchResult.Location = new Point(12, 131);
            listBoxSearchResult.Name = "listBoxSearchResult";
            listBoxSearchResult.Size = new Size(157, 454);
            listBoxSearchResult.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 24;
            label1.Text = "Kategori";
            // 
            // textBoxSearchField
            // 
            textBoxSearchField.Location = new Point(175, 27);
            textBoxSearchField.Name = "textBoxSearchField";
            textBoxSearchField.Size = new Size(176, 23);
            textBoxSearchField.TabIndex = 23;
            // 
            // comboBoxSearchCategory
            // 
            comboBoxSearchCategory.FormattingEnabled = true;
            comboBoxSearchCategory.Location = new Point(12, 27);
            comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            comboBoxSearchCategory.Size = new Size(157, 23);
            comboBoxSearchCategory.TabIndex = 22;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(357, 27);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 21;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(586, 38);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(75, 23);
            buttonLogOut.TabIndex = 19;
            buttonLogOut.Text = "Logga ut";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonLoadUserAdvertisements
            // 
            buttonLoadUserAdvertisements.Location = new Point(565, 9);
            buttonLoadUserAdvertisements.Name = "buttonLoadUserAdvertisements";
            buttonLoadUserAdvertisements.Size = new Size(96, 23);
            buttonLoadUserAdvertisements.TabIndex = 38;
            buttonLoadUserAdvertisements.Text = "Mina annonser";
            buttonLoadUserAdvertisements.UseVisualStyleBackColor = true;
            buttonLoadUserAdvertisements.Click += buttonLoadUserAdvertisements_Click;
            // 
            // button2
            // 
            button2.Location = new Point(424, 591);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 39;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(505, 591);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 40;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 661);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttonLoadUserAdvertisements);
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
            Controls.Add(buttonLogOut);
            Name = "FormMember";
            Text = "Medlemsvy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private ComboBox comboBoxSortSearchResults;
        private Button buttonClearFields;
        private Label label6;
        private ComboBox comboBoxAdvertisementCategory;
        private TextBox textBoxPrice;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox richTextBoxDescription;
        private TextBox textBoxTitle;
        private Label label2;
        private ListBox listBoxSearchResult;
        private Label label1;
        private TextBox textBoxSearchField;
        private ComboBox comboBoxSearchCategory;
        private Button buttonSearch;
        private Button buttonLogOut;
        private Button buttonLoadUserAdvertisements;
        private Button button2;
        private Button button3;
    }
}