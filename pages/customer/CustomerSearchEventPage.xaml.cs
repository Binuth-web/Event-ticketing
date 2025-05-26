using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace sample2.pages.customer
{
    public partial class CustomerSearchEventPage : Page
    {
        public CustomerSearchEventPage()
        {
            InitializeComponent();

            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtPlaceholder.Visibility = string.IsNullOrWhiteSpace(txtSearch.Text)
                ? Visibility.Visible
                : Visibility.Collapsed;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();

            lstResults.Items.Clear();
            if (keyword.Contains("tech"))
                lstResults.Items.Add("Tech Expo 2025");
            else if (keyword.Contains("music"))
                lstResults.Items.Add("Music Night 2025");
            else
                lstResults.Items.Add("No events found.");
        }
    }
}
