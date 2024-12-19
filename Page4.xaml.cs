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
    public partial class Page4 : Window
    {
        public Page4()
        {
            InitializeComponent();
            int a = 0;
            for (a = 1; a <= 9; a++) Text1.Text += $"7 * {a} = {7 * a}\n";

        }
        
    }
}
