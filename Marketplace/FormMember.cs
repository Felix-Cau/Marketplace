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
        }

        List<Advertisement> searchResultList = new();

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
    }
}
