using Marketplace.Entities;
using Marketplace.Helper_classes;
using Marketplace.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marketplace
{
    public partial class FormMember : Form
    {
        Member activeMember = null;
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

        private void comboBoxSortSearchResults_Click(object sender, EventArgs e)
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
            int searchCategory = comboBoxSearchCategory.SelectedIndex;
            string searchTextParameter = textBoxSearchField.Text.Trim();

            searchResultList = AdvertisementRepository.SearchAdvertisement(searchCategory, searchTextParameter);

            listBoxSearchResult.DataSource = searchResultList;
            listBoxSearchResult.DisplayMember = "Title";
            listBoxSearchResult.ValueMember = "AdvertisementID";
        }
    }
}
