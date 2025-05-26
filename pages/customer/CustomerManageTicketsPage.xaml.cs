using System.Data;
using System.Windows.Controls;
using System.Windows;

namespace sample2.pages.customer
{

    public partial class CustomerManageTicketsPage : Page
    {
        public CustomerManageTicketsPage()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string type = (cmbType.SelectedItem as ComboBoxItem)?.Content.ToString();
            MessageBox.Show($"Saved {type} ticket at Rs.{txtPrice.Text} with {txtAvailability.Text} available.", "Saved");
        }
    }
}
