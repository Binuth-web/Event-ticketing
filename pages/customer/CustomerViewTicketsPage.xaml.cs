using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sample2.pages.customer
{
    public partial class CustomerViewTicketsPage : Page
    {
        public CustomerViewTicketsPage()
        {
            InitializeComponent();
            lstTickets.Items.Add("Tech Expo - VIP - 2 Tickets");
            lstTickets.Items.Add("Music Night - General - 1 Ticket");
        }
    }
}