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

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = ayudaNombreTextBlock;
            apellidoTextBox.Tag = ayudaApellidoTextBlock;
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                TextBlock texto=(TextBlock)(sender as TextBox).Tag;
                if(texto.Visibility== Visibility.Hidden)
                {
                    texto.Visibility = Visibility.Visible;
                }
                else{
                    texto.Visibility = Visibility.Hidden;
                }
            }

            

        }

        private void TextBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if (int.TryParse((sender as TextBox).Text, out _))
                {
                    comprobarEdadTextBlock.Visibility = Visibility.Hidden;
                }
                else
                {
                    comprobarEdadTextBlock.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
