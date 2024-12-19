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
    public partial class Page3 : Window
    {
        public Page3()
        {
            InitializeComponent();
            int a = 0, sum = 0;
            for (a = 1; a <= 15; a++) if (a % 2 != 0)
                {
                    Text1.Text += $" {a}\n";
                    sum += a;
                }
            Text1.Text += $"\nСумма: {sum}";

        }
        
    }
}
