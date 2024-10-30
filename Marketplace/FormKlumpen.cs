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
            var searchCategories = CategoryRepository.GetList();

            var advertisementCategory = searchCategories;

            var emptyCategory = new Category(-1, "");
            searchCategories.Insert(0, emptyCategory);

            ComboBoxHelper.SetComboBoxDataSource(comboBoxSearchCategory, searchCategories);
            ComboBoxHelper.SetComboBoxDataSource(comboBoxAdvertisementCategory, searchCategories);
        }

        private void LoadSortingOptions()
        {
            comboBoxSortSearchResults.DataSource = new BindingSource(SorterHelper.SortingOptions, null);
            comboBoxSortSearchResults.DisplayMember = "Key";
            comboBoxSortSearchResults.ValueMember = "Value";
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

        private void comboBoxSortSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = comboBoxSortSearchResults.SelectedValue.ToString();

            var searchResultListSorted = SorterHelper.SortAdvertisementList(sortOption, searchResultList);

            listBoxSearchResult.DataSource = searchResultListSorted;
            listBoxSearchResult.DisplayMember = "Title";
            listBoxSearchResult.ValueMember = "AdvertisementID";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void buttonCreateNewMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegisterMember formRegisterMember = new FormRegisterMember();
            formRegisterMember.ShowDialog();
        }
    }
}
