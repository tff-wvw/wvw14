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
    public partial class Page8 : Window
    {
        public Page8()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string characterSet = "AEIOUYaeiouyАаЕеЁёИиОоУуЫыЭэЮюЯя";
            string input = InputTextBox.Text;
            int counter1 = 0, counter2 = 0, inputLength = input.Length;

            while (counter1 != inputLength)
            {
                if (characterSet.Contains(input[counter1]))
                {
                    counter2++;
                }
                counter1++;
            }

            ResultTextBlock.Text = counter2.ToString();
        }
    }
}
