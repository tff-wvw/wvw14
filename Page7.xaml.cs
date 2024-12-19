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
    public partial class Page7 : Window
    {
        public Page7()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            int a = input.Length;
            string b = "";

            for (int i = a - 1; i >= 0; i--)
            {
                b += input[i];
            }

            ResultTextBlock.Text = $"Перевернутый вариант: " + Environment.NewLine + b ;
        }
    }
}
