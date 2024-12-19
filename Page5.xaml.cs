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
    public partial class Page5 : Window
    {
        public Page5()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int result = 1, a = 0, b = 0;
            if (!int.TryParse(TextBoxOne.Text, out b))
            {
                Text1.Text = "Введите корректное число!";
            }
            else
            {
                for (a = 1; a <= b; a++) result *= a;
                Text1.Text = $"Факториал числа {b}: {result}";
            }
        }
    }
}
