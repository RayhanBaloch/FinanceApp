using Microsoft.Extensions.DependencyInjection;
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
using System.Windows.Shapes;

namespace FinanceAppUI.WPF
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
            DataContext = App.Services.GetRequiredService<ShellViewModel>();
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility
            tt_home.Visibility = Visibility.Visible;
            tt_contacts.Visibility = Visibility.Visible;
            tt_messages.Visibility = Visibility.Visible;
            tt_maps.Visibility = Visibility.Visible;
            tt_settings.Visibility = Visibility.Visible;
            tt_signout.Visibility = Visibility.Visible;
        }
    }
}
