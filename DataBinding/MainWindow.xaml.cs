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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person _person;

        public MainWindow()
        {
            InitializeComponent();

            _person = new Person
            {
                Name = "Jamie",
                Email = "Jamie@123.net",
                Address = "Wall Street",
                Number = 12345
            };

            this.DataContext = person;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int? Number { get; set; }
    }
}