using Marketplace.Entities;
using System.Runtime.CompilerServices;

namespace Marketplace.Helper_classes
{
    public static class ComboBoxHelper
    {
        public static void SetComboBoxDataSourceForCategory(ComboBox comboBox, List<Category> categories)
        {
            var bindingsource = new BindingSource { DataSource = categories };
            comboBox.DataSource = bindingsource;
            comboBox.DisplayMember = "CategoryName";
            comboBox.ValueMember = "CategoryID";
        }

        public static void SetComboBoxDataSourceForMessages(ComboBox comboBox)
        {
            Dictionary<string, string> showMessageType = new()
            {
                { "Mottagna", "Recieved" },
                { "Skickade", "Send" }
            };

            var bindingsource = new BindingSource { DataSource = showMessageType };

            comboBox.DataSource = bindingsource;
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
        }
    }
}
