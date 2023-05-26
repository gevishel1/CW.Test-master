using CW.Test.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CW.Test.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
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
        static void Gauss(double[,] A, int M, int N, int k, TextBlock textBox1)
        {
            // Step 1: Eliminate elements in k-th column
            for (int i = 1; i < M; i++)
            {
                if (A[i, k] != 0)
                {
                    double factor = A[i, k] / A[1, k];
                    for (int j = k; j < N; j++)
                    {
                        A[i, j] -= factor * A[1, j];
                    }
                }
            }
        }
        private void Task_5_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int N = rnd.Next(0,10);
            int M = rnd.Next(0, 10);
            double[,] A = new double [M, N];

            

                // Step 2: Output the resulting matrix
                string output = "";
                for (int i = 1; i < M; i++)
                {
                    for (int j = 1; j < N; j++)
                    {
                        output += A[i, j] + "\t";
                    }
                    output += "\n";
                }

                textBox1.Text = output;
         }


        }
    }
