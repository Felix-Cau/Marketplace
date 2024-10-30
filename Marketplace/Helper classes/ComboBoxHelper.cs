using Marketplace.Entities;

namespace Marketplace.Helper_classes
{
    public static class ComboBoxHelper
    {
        public static void SetComboBoxDataSource(ComboBox comboBox, List<Category> categories)
        {
            var bindingsource = new BindingSource { DataSource = categories };
            comboBox.DataSource = bindingsource;
            comboBox.DisplayMember = "CategoryName";
            comboBox.ValueMember = "CategoryID";
        }
    }
}
