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
    /// Interaction logic for Capitulo4_ejercicio2.xaml
    /// </summary>
    public partial class Capitulo4_ejercicio2 : Window
    {
        public Capitulo4_ejercicio2()
        {
            InitializeComponent();
        }

        private void calcularBtn_Click(object sender, RoutedEventArgs e)
        {
            int numero;
            int exponente;
            int resultado = 1;

            numero = Convert.ToInt32(numeroTextBox.Text);
            exponente = Convert.ToInt32(potenciaTextBox.Text);

            for(int i = 0; i<exponente; i++)
            {
                resultado *= numero;
            }

            resutadoTextBox.Text = (resultado.ToString());

        }

        private void limpiarBtn_Click(object sender, RoutedEventArgs e)
        {
            numeroTextBox.Text = "";
            potenciaTextBox.Text = "";
            resutadoTextBox.Text = "";
        }
    }
}
