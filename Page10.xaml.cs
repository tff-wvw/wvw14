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
    public partial class Page10 : Window
    {
        public Page10()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string line = InputTextBox.Text;
            string result1 = "";

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != ' ')
                {
                    result1 += line[i];
                }
                else
                {
                    result1 += '_';
                }
            }

            ResultTextBlock.Text = result1;
        }
    }
}
