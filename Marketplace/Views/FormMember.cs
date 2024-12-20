﻿using Marketplace.Entities;
using Marketplace.Helper_classes;
using Marketplace.Repository;

namespace Marketplace.Views
{
    public partial class FormMember : Form
    {
        Member activeMember = null;
        Advertisement displayedAdvertisement = null;

        public FormMember(Member member)
        {
            activeMember = member;
            InitializeComponent();
            LoadCategories();
            LoadSortingOptions();
        }

        List<Advertisement> searchResultList = new();

        private void LoadCategories()
        {
            var searchCategories = CategoryRepository.GetList();

            var advertisementCategory = searchCategories;

            var emptyCategory = new Category(-1, "");
            searchCategories.Insert(0, emptyCategory);

            ComboBoxHelper.SetComboBoxDataSourceForCategory(comboBoxSearchCategory, searchCategories);
            ComboBoxHelper.SetComboBoxDataSourceForCategory(comboBoxAdvertisementCategory, advertisementCategory);
        }
        private void LoadSortingOptions()
        {
            comboBoxSortSearchResults.DataSource = new BindingSource(SorterHelper.SortingOptions, null);
            comboBoxSortSearchResults.DisplayMember = "Key";
            comboBoxSortSearchResults.ValueMember = "Value";
        }

        private void buttonLoadUserAdvertisements_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.DataSource = AdvertisementRepository.GetListBasedOnUser(activeMember);
            listBoxSearchResult.DisplayMember = "Title";
            listBoxSearchResult.ValueMember = "AdvertisementID";
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKlumpen formKlumpen = new();
            formKlumpen.ShowDialog();
        }

        private void comboBoxSortSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = comboBoxSortSearchResults.SelectedValue.ToString();

            listBoxSearchResult.DataSource = SorterHelper.SortAdvertisementList(sortOption, searchResultList);
            listBoxSearchResult.DisplayMember = "Title";
            listBoxSearchResult.ValueMember = "AdvertisementID";
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.DataSource = new List<Advertisement>();
            textBoxTitle.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            richTextBoxDescription.Text = string.Empty;
            textBoxSearchField.Text = string.Empty;
            textBoxDateCreated.Text = string.Empty;
            textBoxUsername.Text = string.Empty;
            LoadCategories();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int searchCategory = (int)comboBoxSearchCategory.SelectedValue;
            string searchTextParameter = textBoxSearchField.Text.Trim();

            searchResultList = AdvertisementRepository.SearchAdvertisement(searchCategory, searchTextParameter);

            listBoxSearchResult.DataSource = searchResultList;
            listBoxSearchResult.DisplayMember = "Title";
            listBoxSearchResult.ValueMember = "AdvertisementID";
        }

        private void listBoxSearchResult_Click(object sender, EventArgs e)
        {
            int advertisementID = (int)listBoxSearchResult.SelectedValue;

            displayedAdvertisement = searchResultList.SingleOrDefault(x => x.AdvertisementID == advertisementID);

            if (displayedAdvertisement is not null)
            {
                textBoxTitle.Text = displayedAdvertisement.Title;
                textBoxPrice.Text = displayedAdvertisement.Price.ToString();
                richTextBoxDescription.Text = displayedAdvertisement.Description;
                comboBoxAdvertisementCategory.SelectedValue = displayedAdvertisement.CategoryID;
                textBoxDateCreated.Text = displayedAdvertisement.Date.ToString();
                textBoxUsername.Text = displayedAdvertisement.Username;
            }
            else
            {
                MessageBox.Show("Något gick fel. Försök igen.");
            }
        }

        private void buttonRemoveAdvertisement_Click(object sender, EventArgs e)
        {

            if (displayedAdvertisement.Username != activeMember.Username)
            {
                MessageBox.Show("Du kan bara ta bort annonser du själv har skapat.");
            }
            else
            {
                AdvertisementRepository.Delete(displayedAdvertisement);

                buttonClearFields_Click(sender, e);
            }
        }

        private void buttonUpdateAdvertisement_Click(object sender, EventArgs e)
        {
            if (displayedAdvertisement.Username != activeMember.Username)
            {
                MessageBox.Show("Du kan bara uppdatera annonser du själv har skapat.");
            }
            else
            {
                bool successfullParse = int.TryParse(textBoxPrice.Text.Replace(" ", ""), out int price);

                if (successfullParse)
                {
                    displayedAdvertisement.SetAdvertisementTitle(textBoxTitle.Text);
                    displayedAdvertisement.SetAdvertisementDescription(richTextBoxDescription.Text);
                    displayedAdvertisement.SetAdvertisementPrice(price);
                    displayedAdvertisement.SetAdvertisementCategoryID((int)comboBoxAdvertisementCategory.SelectedValue);

                    AdvertisementRepository.Update(displayedAdvertisement);

                    MessageBox.Show("Annonsen är uppdaterad.");
                    buttonClearFields_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Du har inte angett ett korrekt värde som pris. Försök igen.");
                }
            }
        }

        private void buttonSaveNewAdvertisement_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text.Trim() != string.Empty && textBoxPrice.Text.Replace(" ", "") != string.Empty && (int)comboBoxAdvertisementCategory.SelectedValue != -1 &&
               richTextBoxDescription.Text.Trim() != string.Empty)
            {
                bool successfullParse = int.TryParse(textBoxPrice.Text.Replace(" ", ""), out int price);

                if (successfullParse)
                {
                    Advertisement newAdvertisement = new(textBoxTitle.Text.Trim(), richTextBoxDescription.Text.Trim(), activeMember.Username, price, (int)comboBoxAdvertisementCategory.SelectedValue);

                    AdvertisementRepository.Save(newAdvertisement);

                    MessageBox.Show("Annonsen sparad.");

                    buttonClearFields_Click(sender, e);
                }

            }
            else
            {
                MessageBox.Show("Fälten titel, beskrivning, pris och annonskategori måste vara ifyllda.");
            }
        }

        private void buttonMessages_Click(object sender, EventArgs e)
        {
            FormMessages formMessages = new FormMessages(activeMember);
            formMessages.ShowDialog();
        }

        private void buttonSendMessageToAdvertisementUser_Click(object sender, EventArgs e)
        {
            FormMessages formMessages = new FormMessages(activeMember, displayedAdvertisement);
            formMessages.ShowDialog();
        }
    }
}
