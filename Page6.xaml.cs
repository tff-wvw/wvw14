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
    public partial class Page6 : Window
    {
        public Page6()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int rangeA, rangeB;

            while (!int.TryParse(RangeATextBox.Text, out rangeA))
            {
                ResultTextBlock.Text = "Введите корректное число для начала диапазона!";
            }

            while (!int.TryParse(RangeBTextBox.Text, out rangeB))
            {
                ResultTextBlock.Text = "Введите корректное число для конца диапазона!";
            }

            while (rangeA <= rangeB)
            {
                if (rangeA == 2 || rangeA == 3 || rangeA == 5 || rangeA == 7 || rangeA == 13 || rangeA % 2 != 0 && rangeA % 3 != 0 && rangeA % 5 != 0 && rangeA % 7 != 0 && rangeA % 13 != 0)
                {
                    ResultTextBlock.Text += $" {rangeA}" ;
                }
                rangeA++;
            }
        }
    }
}
