using System.Windows;
using WPFRelayCommand.ViewModel;

namespace WPFRelayCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MessageViewModel();
        }
    }
}
