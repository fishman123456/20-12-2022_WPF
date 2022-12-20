using System;
using System.Collections;
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

namespace _20_12_2022_WPF
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

        private void _1_Красный_Click(object sender, RoutedEventArgs e)
        {
            _Stack_Panel_1.Background = Brushes.Red;
            
        }
        private void _2_Оранжевый_Click(object sender, RoutedEventArgs e)
        {
            _Stack_Panel_1.Background = Brushes.Orange;
        }

        private void _3_Желтый_Click(object sender, RoutedEventArgs e)
        {
            _Stack_Panel_1.Background = Brushes.Yellow;
        }

        private void _4_Зеленый_Click(object sender, RoutedEventArgs e)
        {
            _Stack_Panel_1.Background = Brushes.Green;
        }

        private void _5_Синий_Click(object sender, RoutedEventArgs e)
        {
            _Stack_Panel_1.Background = Brushes.Blue;
        }

        private void _6_Фиолетовый_Click(object sender, RoutedEventArgs e)
        {
            _Stack_Panel_1.Background = Brushes.Violet;
        }

        private void _7_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void _Stack_Panel_1_Click(object sender, RoutedEventArgs e)
        {
            _Stack_Panel_1.Background = Brushes.White;
        }
    }
}
