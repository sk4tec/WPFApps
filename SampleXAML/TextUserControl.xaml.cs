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

namespace SampleXAML
{
    /// <summary>
    /// Interaction logic for TextUserControl.xaml
    /// </summary>
    public partial class TextUserControl : UserControl
    {
        public static readonly DependencyProperty ControlTextProperty = DependencyProperty.Register(
            "ControlText",
            typeof(string),
            typeof(TextUserControl),
            new PropertyMetadata(string.Empty));

        public string ControlText
        {
            get { return (string)GetValue(ControlTextProperty); }
            set { SetValue(ControlTextProperty, value); }
        }

        public TextUserControl()
        {
            DataContext = this;
            InitializeComponent();
        }
        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ControlText = "You clicked the TextBlock!";
        }
    }
}
