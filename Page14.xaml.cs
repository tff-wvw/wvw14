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
    public partial class Page14 : Window
    {
        public Page14()
        {
            InitializeComponent();
            for (int a = 1; a <= 100; a++)
            {
                if (a % 3 == 0 && a % 5 == 0)
                {
                    ResultTextBlock.Text += a + Environment.NewLine;
                }
            }

        }
    }
}
