using DiarioGeneral.UI.Registros;
using System.Windows;

namespace DiarioGeneral
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

        private void DiarioMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rDiario Window = new();
            Window.Show();
        }

        private void BalanceMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rBalance Window = new();
            Window.Show();
        }
    }
}
