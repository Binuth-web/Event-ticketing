using System.Windows;
using System.Windows.Controls;

namespace sample2.pages.customer
{
    public partial class CustomerCancelTicketPage : Page
    {
        public CustomerCancelTicketPage()
        {
            InitializeComponent(); // This will now work if class and xaml are correct
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ticket canceled successfully!", "Canceled");
        }
    }
}

