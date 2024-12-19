using ConsoleApp9;
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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page12 : Window
    {
        public Page12()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 0, b = 1, n;

            while (!int.TryParse(InputTextBox.Text, out n))
            {
                ResultTextBlock.Text = "Введите корректное число!";
            }

            while (a <= n)
            {
                ResultTextBlock.Text += a + Environment.NewLine;
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
}
