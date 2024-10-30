using Marketplace.Entities;
using Marketplace.Helper_classes;
using Marketplace.Repository;

namespace Marketplace
{
    public partial class FormMember : Form
    {
        Member activeMember = null;
        Advertisement displayAdvertisement = null;

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

            ComboBoxHelper.SetComboBoxDataSource(comboBoxSearchCategory, searchCategories);
            ComboBoxHelper.SetComboBoxDataSource(comboBoxAdvertisementCategory, advertisementCategory);
        }
        private void LoadSortingOptions()
        {
            comboBoxSortSearchResults.DataSource = new BindingSource(SorterHelper.SortingOptions, null);
            comboBoxSortSearchResults.DisplayMember = "Key";
            comboBoxSortSearchResults.ValueMember = "Value";
        }

        private void buttonLoadUserAdvertisements_Click(object sender, EventArgs e)
        {
            searchResultList = AdvertisementRepository.GetListBasedOnUser(activeMember);

            listBoxSearchResult.DataSource = searchResultList;
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

            var searchResultListSorted = SorterHelper.SortAdvertisementList(sortOption, searchResultList);

            searchResultList = searchResultListSorted;
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.DataSource = new List<Advertisement>();
            textBoxTitle.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            richTextBoxDescription.Text = string.Empty;
            textBoxSearchField.Text = string.Empty;
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

            displayAdvertisement = searchResultList.SingleOrDefault(x => x.AdvertisementID == advertisementID);

            if (displayAdvertisement is not null)
            {
                textBoxTitle.Text = displayAdvertisement.Title;
                textBoxPrice.Text = displayAdvertisement.Price.ToString();
                richTextBoxDescription.Text = displayAdvertisement.Description;
                comboBoxAdvertisementCategory.SelectedValue = displayAdvertisement.CategoryID;
                textBoxDateCreated.Text = displayAdvertisement.Date.ToString();
                textBoxUsername.Text = displayAdvertisement.Username;
            }
            else
            {
                MessageBox.Show("Något gick fel. Försök igen.");
            }
        }

        private void buttonRemoveAdvertisement_Click(object sender, EventArgs e)
        {

            if (displayAdvertisement.Username != activeMember.Username)
            {
                MessageBox.Show("Du kan bara ta bort annonser du själv har skapat.");
            }
            else
            {
                AdvertisementRepository.Delete(displayAdvertisement);

                buttonClearFields_Click(sender, e);
            }
        }

        private void buttonUpdateAdvertisement_Click(object sender, EventArgs e)
        {
            if (displayAdvertisement.Username != activeMember.Username)
            {
                MessageBox.Show("Du kan bara uppdatera annonser du själv har skapat.");
            }
            else
            {
                bool successfullParse = int.TryParse(textBoxPrice.Text.Replace(" ", ""), out int price);

                if (successfullParse)
                {
                    displayAdvertisement.SetAdvertisementTitle(textBoxTitle.Text);
                    displayAdvertisement.SetAdvertisementDescription(richTextBoxDescription.Text);
                    displayAdvertisement.SetAdvertisementPrice(price);
                    displayAdvertisement.SetAdvertisementCategoryID((int)comboBoxAdvertisementCategory.SelectedValue);

                    AdvertisementRepository.Update(displayAdvertisement);

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
    }
}
