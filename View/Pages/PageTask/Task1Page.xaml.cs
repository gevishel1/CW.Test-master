using CW.Test.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CW.Test.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task1Page());
        }
        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task2Page());
        }
        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task3Page());
        }
        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task4Page());
        }
        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task5Page());
        }
        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?",
                "Системное сообщение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                CoreTest.TestFrame?.Navigate(new MainPage());
            }
        }
        private int ConvertToDecimal(string number, int p)
        {
            int result = 0;
            int power = 1;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int value = GetValueOf(number[i]);
                result += value * power;
                power *= p;
            }

            return result;
        }

        private int GetValueOf(char c)
        {
            if (Char.IsDigit(c))
            {
                return (int)Char.GetNumericValue(c);
            }
            else
            {
                return (int)c - 55;
            }
        }


        private void Task_1_Click(object sender, RoutedEventArgs e)
        {

            int p = 5;
            int result = ConvertToDecimal(numberTextBox.Text, p);
            numberTextBox.Text = result.ToString();
        }
    }
}