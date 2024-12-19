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
    public partial class Page13 : Window
    {
        private int randomNumber;
        private int guess;
        private Random random;
        private int count = 1;
        public Page13()
        {
            random = new Random();
            randomNumber = random.Next(1, 50);
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(GuessTextBox.Text, out guess))
            {
                if (guess == randomNumber)
                {
                    ResultTextBlock.Text = $"Вы угадали!" + Environment.NewLine + "Число попыток: " + count + Environment.NewLine + " Загаданное число: " + randomNumber;
                }
                else if (guess > randomNumber)
                {
                    count++;
                    ResultTextBlock.Text = "Вы не угадали." + Environment.NewLine + "Загаданное число меньше.";
                }
                else
                {
                    count++;
                    ResultTextBlock.Text = "Вы не угадали." + Environment.NewLine + " Загаданное число больше.";
                }
            }
            else
            {
                ResultTextBlock.Text = "Введите корректное число!";
            }

        }
    }
}
