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
using ProyectoTarea2.UI;

namespace ProyectoTarea2
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

        private void menuItemC1_Click(object sender, RoutedEventArgs e)
        {
            Capitulo4_ejercicio1 ejercicio1 = new Capitulo4_ejercicio1();
            ejercicio1.Show();
        }

        private void menuItem2C1_Click(object sender, RoutedEventArgs e)
        {
            Capitulo4_ejercicio2 ejercicio2 = new Capitulo4_ejercicio2();
            ejercicio2.Show();
        }

        private void menuItem3c1_Click(object sender, RoutedEventArgs e)
        {
            Capitulo4_ejercicio5 ejercicio5 = new Capitulo4_ejercicio5();
            ejercicio5.Show();
        }

        private void menuItemC5_Click(object sender, RoutedEventArgs e)
        {
            Capitulo5_ejercicio4 ejercicio4 = new Capitulo5_ejercicio4();
            ejercicio4.Show();
        }

        private void menuItem2C5_Click(object sender, RoutedEventArgs e)
        {
            Capitulo5_ejercicio5 ejercicio5 = new Capitulo5_ejercicio5();
            ejercicio5.Show();
        }
    }
}
