using System.Windows;
using System.Windows.Controls;

namespace sample2.pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        public void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Password;

            if (username == "Customer" && password == "admin123")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                // ✅ Navigate to dashboard with role
                if (username == "Customer" && password == "admin123")
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                    // ✅ Open dashboard as Page
                    dashboard dashboardPage = new dashboard("Customer");
                    NavigationService?.Navigate(dashboardPage); // works if hosted in a Frame or NavigationWindow
                }


                //if (NavigationService != null)
                //{
                //    NavigationService.Navigate(dashboardPage);
                //}
                //else
                //{
                //    MessageBox.Show("NavigationService is null. Make sure this page is hosted in a Frame.");
                //}
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
