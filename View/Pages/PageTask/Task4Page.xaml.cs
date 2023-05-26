using CW.Test.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CW.Test.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
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
        void Smooth(double[] A, int N, TextBox textBox)
        {
            double[] B = new double[N];
            for (int iter = 0; iter < 5; iter++)
            {
                for (int i = 1; i < N - 1; i++)
                {
                    B[i] = (A[i - 1] + A[i] + A[i + 1]) / 3;
                }
                B[0] = A[0];
                B[N - 1] = A[N - 1];
                Array.Copy(B, A, N);
                textBox.AppendText($"Iteration {iter + 1}: {string.Join(", ", A)}\n");
            }
        }

        private void Task_4_Click(object sender, RoutedEventArgs e)
        {
            double[] A = { 1, 2, 3, 4, 5 };
            int N = A.Length;
            TextBox textBox = new TextBox();
            Smooth(A, N, textBox);
            numberTextBox.Text = textBox.Text;
        }
    }
}