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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio1
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

       static Random rnd = new Random();
        int aleatorio = rnd.Next(0, 100);

        private void ComprobarBoton(object sender, RoutedEventArgs e)
        {
            //
            
            try
            {
                if (int.Parse(TextNumero.Text) > aleatorio)
                {
                    MayorMenor.Text = "El numero es menor";
                }
                else if (int.Parse(TextNumero.Text) < aleatorio)
                {
                    MayorMenor.Text = "El numero es mayor";
                }else MayorMenor.Text = "Enhorabuena numero correcto";

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void ReiniciarBoton(object sender,RoutedEventArgs e)
        {
            MayorMenor.Text = "";
            TextNumero.Text = "";
            aleatorio = rnd.Next(0, 100); 

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
