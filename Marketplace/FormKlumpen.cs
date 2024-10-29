using Marketplace.Entities;
using Marketplace.Repository;

namespace Marketplace
{
    public partial class FormKlumpen : Form
    {
        public FormKlumpen()
        {
            InitializeComponent();
            LoadCategories();
        }

        List<Advertisement> searchResultAdvertisement = new();
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int searchCategory = comboBoxSearchCategory.SelectedIndex;
            string searchTextParameter = textBoxSearchField.Text.Trim();

            searchResultAdvertisement = AdvertisementRepository.SearchAdvertisement(searchCategory, searchTextParameter);

            listBoxSearchResult.DataSource = searchResultAdvertisement;
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

            displayAdvertisement = searchResultAdvertisement.SingleOrDefault(x => x.AdvertisementID == advertisementID);

            if(displayAdvertisement is not null)
            {
                textBoxTitle.Text = displayAdvertisement.Title;
                textBoxPrice.Text = displayAdvertisement.Price.ToString();
                richTextBoxDescription.Text = displayAdvertisement.Description;
                comboBoxAdvertisementCategory.SelectedValue = displayAdvertisement.CategoryID;
            }
            else
            {
                MessageBox.Show("Something went wrong. Try again.");
            }
        }
    }
}
