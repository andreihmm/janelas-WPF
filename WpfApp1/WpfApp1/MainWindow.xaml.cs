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
using WpfApp1.NomeCompleto;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private int _contador = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addContador(object sender, RoutedEventArgs e)
        {
            _contador++;
            LabelContador.Content = _contador;
        }

        private void decrescer(object sender, RoutedEventArgs e)
        {
            _contador--; LabelContador.Content = _contador;

        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            _contador = 0; LabelContador.Content = _contador;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NomeCompleto.NomeCompleto n = new();
            n.Show();
        }
    }
}