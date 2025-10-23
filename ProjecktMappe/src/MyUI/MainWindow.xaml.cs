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
using Vpets.Models.Base;


/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
namespace MyUI
{
    public partial class MainWindow : Window
    {
        public Pet Moony { get; } = new("Moony");
        public Pet Speedy { get; } = new("Speedy");
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void OnClickMoony(object sender, RoutedEventArgs e)
        {
            Moony.Energy += 20;
        }
        private void OnClickSpeedy(object sender, RoutedEventArgs e)
        {
            Speedy.Energy += 20;
        }
    }
}