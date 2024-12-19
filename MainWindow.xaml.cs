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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonOne_Click(object sender, RoutedEventArgs e)
        {
            Page1 taskWindow = new Page1();
            taskWindow.Show();
            Close();
        }

        private void buttonTwo_Click(object sender, RoutedEventArgs e)
        {
            Page2 taskWindow = new Page2();
            taskWindow.Show();
            Close();
        }

        private void buttonThree_Click(object sender, RoutedEventArgs e)
        {
            Page3 taskWindow = new Page3();
            taskWindow.Show();
            Close();
        }

        private void buttonFour_Click(object sender, RoutedEventArgs e)
        {
            Page4 taskWindow = new Page4();
            taskWindow.Show();
            Close();
        }

        private void buttonFive_Click(object sender, RoutedEventArgs e)
        {
            Page5 taskWindow = new Page5();
            taskWindow.Show();
            Close();
        }

        private void buttonSix_Click(object sender, RoutedEventArgs e)
        {
            Page6 taskWindow = new Page6();
            taskWindow.Show();
            Close();

        }

        private void buttonSeven_Click(object sender, RoutedEventArgs e)
        {
            Page7 taskWindow = new Page7();
            taskWindow.Show();
            Close();

        }

        private void buttonEight_Click(object sender, RoutedEventArgs e)
        {
            Page8 taskWindow = new Page8();
            taskWindow.Show();
            Close();

        }

        private void buttonNine_Click(object sender, RoutedEventArgs e)
        {
            Page9 taskWindow = new Page9();
            taskWindow.Show();
            Close();

        }

        private void buttonTen_Click(object sender, RoutedEventArgs e)
        {
            Page10 taskWindow = new Page10();
            taskWindow.Show();
            Close();

        }

        private void buttonEleven_Click(object sender, RoutedEventArgs e)
        {
            Page11 taskWindow = new Page11();
            taskWindow.Show();
            Close();

        }

        private void buttonTwelve_Click(object sender, RoutedEventArgs e)
        {
            Page12 taskWindow = new Page12();
            taskWindow.Show();
            Close();
        }

        private void buttonThirteen_Click(object sender, RoutedEventArgs e)
        {
            Page13 taskWindow = new Page13();
            taskWindow.Show();
            Close();

        }

        private void buttonFourteen_Click(object sender, RoutedEventArgs e)
        {
            Page14 taskWindow = new Page14();
            taskWindow.Show();
            Close();

        }

        private void buttonFifteen_Click(object sender, RoutedEventArgs e)
        {
            Page15 taskWindow = new Page15();
            taskWindow.Show();
            Close();

        }
    }
}
