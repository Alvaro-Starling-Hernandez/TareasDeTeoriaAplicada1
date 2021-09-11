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

namespace ProyectoTarea2.UI
{
    /// <summary>
    /// Interaction logic for Capitulo5_ejercicio4.xaml
    /// </summary>
    public partial class Capitulo5_ejercicio4 : Window
    {
        public Capitulo5_ejercicio4()
        {
            InitializeComponent();
        }

        private void calcularBtn_Click(object sender, RoutedEventArgs e)
        {
            factorial();
        }

        private void limpiarBtn_Click(object sender, RoutedEventArgs e)
        {
            numeroTextBox.Text = "";
            factorialTextBox.Text = "";
        }

        private void factorial()
        {
            int numero;
            int factorial = 1;

            numero = Convert.ToInt32(numeroTextBox.Text);

            if (numero < 0)
                factorial = 0;
            else if (numero == 0) 
                factorial = 1;
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }
            }

            factorialTextBox.Text = factorial.ToString();
        }
    }
}
