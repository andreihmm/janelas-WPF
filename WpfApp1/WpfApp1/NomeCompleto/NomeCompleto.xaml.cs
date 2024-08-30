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

namespace WpfApp1.NomeCompleto
{
    /// <summary>
    /// Lógica interna para NomeCompleto.xaml
    /// </summary>
    public partial class NomeCompleto : Window
    {
        public NomeCompleto()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void botao_Click(object sender, RoutedEventArgs e)
        {
            output.Content = inputNome.Text + inputSobrenome.Text;
        }

        private void inputSobrenome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
