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
    /// Interaction logic for Capitulo4_ejercicio5.xaml
    /// </summary>
    public partial class Capitulo4_ejercicio5 : Window
    {
        public Capitulo4_ejercicio5()
        {
            InitializeComponent();
        }

        private void aceptarBtn_Click(object sender, RoutedEventArgs e)
        {
            int e1, e2, e3, eMayor, eMenor,promedio;

            e1 = Convert.ToInt32(persona1TextBox.Text);
            e2 = Convert.ToInt32(perosona2TextBox.Text);
            e3 = Convert.ToInt32(persona3TextBox.Text);

            eMayor = e1;

            if (e1 < e2)
            {
                eMayor = e2;
            }
            if (e1 < e3)
            {
                eMayor = e3;
            }

            eMenor = e1;

            if (e1 > e2)
            {
                eMenor = e2;
            }
            if (e1 > e3)
            {
                eMenor = e3;
            }

            promedio = (e1 + e2 + e3) / 3;

            edadMayorTextBox.Text = eMayor.ToString();
            edadMenorTextBox.Text = eMenor.ToString();
            promedioTextBox.Text = promedio.ToString();
        }

        private void limpiarBtn_Click(object sender, RoutedEventArgs e)
        {
            persona1TextBox.Text = "";
            perosona2TextBox.Text = "";
            persona3TextBox.Text = "";
            edadMayorTextBox.Text = "";
            edadMenorTextBox.Text = "";
            promedioTextBox.Text = "";
        }
    }
}
