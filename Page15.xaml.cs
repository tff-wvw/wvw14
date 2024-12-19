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
    public partial class Page15 : Window
    {
        public Page15()
        {
            InitializeComponent();
            int a = 0, b = 1;

            while (a != 10)
            {
                ResultTextBlock.Text += $"{b}. Hello, world!" + Environment.NewLine;
                a++;
                b++;
            }
        }
    }
}
