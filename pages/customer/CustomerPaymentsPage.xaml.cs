using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace sample2.pages.customer
{
    public partial class CustomerPaymentsPage : Page
    {
        public CustomerPaymentsPage()
        {
            InitializeComponent();

            // Wire up placeholder behavior
            txtCardNumber.TextChanged += (s, e) =>
                phCard.Visibility = string.IsNullOrWhiteSpace(txtCardNumber.Text) ? Visibility.Visible : Visibility.Collapsed;

            txtName.TextChanged += (s, e) =>
                phName.Visibility = string.IsNullOrWhiteSpace(txtName.Text) ? Visibility.Visible : Visibility.Collapsed;

            txtAmount.TextChanged += (s, e) =>
                phAmount.Visibility = string.IsNullOrWhiteSpace(txtAmount.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please complete all fields.", "Missing Information", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show("Payment processed successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
