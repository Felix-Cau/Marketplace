using Marketplace.Entities;
using Marketplace.Helper_classes;
using Marketplace.Repository;

namespace Marketplace
{
    public partial class FormKlumpen : Form
    {
        public FormKlumpen()
        {
            InitializeComponent();
            LoadCategories();
            LoadSortingOptions();
        }

        List<Advertisement> searchResultList = new();
        Advertisement displayAdvertisement = null;

        private void LoadCategories()
        {
            var categories = CategoryRepository.GetList();

            comboBoxSearchCategory.DataSource = categories;
            comboBoxSearchCategory.DisplayMember = "CategoryName";
            comboBoxSearchCategory.ValueMember = "CategoryID";

            comboBoxAdvertisementCategory.DataSource = categories;
            comboBoxAdvertisementCategory.DisplayMember = "CategoryName";
            comboBoxAdvertisementCategory.ValueMember = "CategoryID";
        }

        private void LoadSortingOptions()
        {
            comboBoxSortSearchResults.DataSource = new BindingSource(SorterHelper.SortingOptions, null);
            comboBoxSortSearchResults.DisplayMember = "Key";
            comboBoxSortSearchResults.ValueMember = "Value";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int searchCategory = comboBoxSearchCategory.SelectedIndex;
            string searchTextParameter = textBoxSearchField.Text.Trim();

            searchResultList = AdvertisementRepository.SearchAdvertisement(searchCategory, searchTextParameter);

            listBoxSearchResult.DataSource = searchResultList;
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
            LoadCategories();
        }

        private void listBoxSearchResult_Click(object sender, EventArgs e)
        {
            int advertisementID = listBoxSearchResult.SelectedIndex;

            displayAdvertisement = searchResultList.SingleOrDefault(x => x.AdvertisementID == advertisementID);

            if (displayAdvertisement is not null)
            {
                textBoxTitle.Text = displayAdvertisement.Title;
                textBoxPrice.Text = displayAdvertisement.Price.ToString();
                richTextBoxDescription.Text = displayAdvertisement.Description;
                comboBoxAdvertisementCategory.SelectedValue = displayAdvertisement.CategoryID;
            }
            else
            {
                MessageBox.Show("Något gick fel. Försök igen.");
            }
        }

        private void comboBoxSortSearchResults_Click(object sender, EventArgs e)
        {
            string sortOption = comboBoxSortSearchResults.SelectedValue.ToString();

            var searchResultListSorted = SorterHelper.SortAdvertisementList(sortOption, searchResultList);

            searchResultList = searchResultListSorted;
        }
    }
}
