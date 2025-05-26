using sample2.pages.customer;
using System.Windows;
using System.Windows.Controls;

namespace sample2.pages
{
    public partial class dashboard : Page
    {
        private string role;

        public dashboard(string userRole)
        {
            InitializeComponent();
            role = userRole;
            txtRoleHeader.Text = $"Logged in as: {role}";
            ShowButtonsForRole();
        }

        private void ShowButtonsForRole()
        {
            // Show only buttons for the logged-in user
            switch (role)
            {
                case "Customer":
                    btnRegister.Visibility = Visibility.Visible;
                    btnSearch.Visibility = Visibility.Visible;
                    btnManageTickets.Visibility = Visibility.Visible;
                    btnPurchase.Visibility = Visibility.Visible;
                    btnView.Visibility = Visibility.Visible;
                    btnCancel.Visibility = Visibility.Visible;
                    btnPayments.Visibility = Visibility.Visible;
                    break;

                case "Admin":
                    btnManageUsers.Visibility = Visibility.Visible;
                    btnReports.Visibility = Visibility.Visible;
                    btnTrackSales.Visibility = Visibility.Visible;
                    break;

                case "Organizer":
                    btnCreateEvent.Visibility = Visibility.Visible;
                    btnSetPrices.Visibility = Visibility.Visible;
                    btnAvailability.Visibility = Visibility.Visible;
                    btnOverbooking.Visibility = Visibility.Visible;
                    break;

                case "Support Staff":
                    btnSupport.Visibility = Visibility.Visible;
                    break;

                case "Venue Manager":
                    btnAllocate.Visibility = Visibility.Visible;
                    btnVenueDetails.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string option = button?.Content.ToString();

            switch (option)
            {
                // Customer
                case "Register for Events":
                    MainFrame.Navigate(new CustomerRegisterEventPage());
                    break;
                case "Search Events":
                    MainFrame.Navigate(new CustomerSearchEventPage());
                    break;
                case "Manage Ticket Types":
                    MainFrame.Navigate(new CustomerManageTicketsPage());
                    break;
                case "Purchase Tickets":
                    MainFrame.Navigate(new CustomerPurchaseTicketPage());
                    break;
                case "View Purchased Tickets":
                    MainFrame.Navigate(new CustomerViewTicketsPage());
                    break;
                case "Cancel Tickets":
                    MainFrame.Navigate(new CustomerCancelTicketPage());
                    break;
                case "Payments":
                    MainFrame.Navigate(new CustomerPaymentsPage());
                    break;

                //// Admin
                //case "Manage Users":
                //    MainFrame.Navigate(new AdminManageUsersPage());
                //    break;
                //case "Generate Reports":
                //    MainFrame.Navigate(new AdminGenerateReportsPage());
                //    break;
                //case "Track Ticket Sales":
                //    MainFrame.Navigate(new AdminTrackSalesPage());
                //    break;

                //// Organizer
                //case "Create/Edit/Delete Event":
                //    MainFrame.Navigate(new OrganizerCreateEditEventPage());
                //    break;
                //case "Set Ticket Types and Prices":
                //    MainFrame.Navigate(new OrganizerSetTicketTypesPage());
                //    break;
                //case "Manage Availability":
                //    MainFrame.Navigate(new OrganizerAvailabilityPage());
                //    break;
                //case "Handle Overbooking":
                //    MainFrame.Navigate(new OrganizerOverbookingPage());
                //    break;

                //// Support
                //case "Resolve Customer Issues":
                //    MainFrame.Navigate(new SupportResolveIssuesPage());
                //    break;

                //// Venue Manager
                //case "Allocate Seats":
                //    MainFrame.Navigate(new VenueAllocateSeatsPage());
                //    break;
                //case "Manage Venue Details":
                //    MainFrame.Navigate(new VenueDetailsPage());
                //    break;
            }
        }
    }
}

