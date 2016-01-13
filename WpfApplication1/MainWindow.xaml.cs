using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApplication1
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ху 2");
            MessageBox.Show("Х уй2");
            MessageBox.Show("Х уй3 ");
            MessageBox.Show("Х у й 4");

            MessageBox.Show("Ху 21");
            MessageBox.Show("Хуй22");
            MessageBox.Show("Хуй33");
            MessageBox.Show("Хуй44");

            MessageBox.Show("Ху 25");
            MessageBox.Show("Хуй26");
            MessageBox.Show("Хуй37");
            MessageBox.Show("Хуй48");
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Хуй3");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Писька");
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Жопа 2");
        }
    }
}
