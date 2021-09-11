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
    /// Interaction logic for Capitulo4_ejercicio1.xaml
    /// </summary>
    public partial class Capitulo4_ejercicio1 : Window
    {
        
        public Capitulo4_ejercicio1()
        {
            InitializeComponent();
        }

        private void calculartBtn_Click(object sender, RoutedEventArgs e)
        {
            int numero;
            int resultado;
            numero = Convert.ToInt32(numeroTextbox.Text);

            for(int i = 1; i<=10; i++)
            {
                resultado = numero * i;
                tablaTextBox.Text += (numero + "x" + i + "=" + resultado.ToString() + "\n");

            }
        }

        private void limpiarBtn_Click(object sender, RoutedEventArgs e)
        {
            numeroTextbox.Text = "";
            tablaTextBox.Text = "";
        }
    }
}
