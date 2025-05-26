using System.Windows;
using System.Windows.Controls;

namespace sample2.pages.customer
{
    public partial class CustomerRegisterEventPage : Page
    {
        public CustomerRegisterEventPage()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string name = txtEventName.Text;
            string date = dpEventDate.SelectedDate?.ToShortDateString();
            string category = (cmbCategory.SelectedItem as ComboBoxItem)?.Content.ToString();
            string location = txtLocation.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(location) || dpEventDate.SelectedDate == null)
            {
                MessageBox.Show("Please fill in all fields.", "Missing Info", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show($"Event '{name}' registered successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            // Later: Save to DB or API
        }
    }
}
