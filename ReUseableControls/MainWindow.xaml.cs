using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReUseableControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnJoinBasicClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You Joined the Basic tier.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void OnJoinProClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You Joined the Pro tier.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void OnJoinEnterpriseClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You Joined the Enterprise tier.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}