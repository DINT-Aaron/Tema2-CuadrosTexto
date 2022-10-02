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
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1 && (sender as TextBox).Tag.Equals("Nombre"))
            {
                if (ayudaNombreTextBlock.Visibility == Visibility.Visible)
                {
                    ayudaNombreTextBlock.Visibility = Visibility.Hidden;
                }
                else
                {
                    ayudaNombreTextBlock.Visibility = Visibility.Visible;

                }
            }
            else if(e.Key == Key.F1 && (sender as TextBox).Tag.Equals("Apellido"))
            {
                if (ayudaApellidoTextBlock.Visibility == Visibility.Visible)
                {
                    ayudaApellidoTextBlock.Visibility = Visibility.Hidden;
                }
                else
                {
                    ayudaApellidoTextBlock.Visibility = Visibility.Visible;

                }
            }
            else if(e.Key == Key.F2 && (sender as TextBox).Tag.Equals("Edad"))
            {
                if(int.TryParse((sender as TextBox).Text, out int n))
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
