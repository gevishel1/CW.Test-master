using CW.Test.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace CW.Test.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class Task2Page : Page
    {
        public Task2Page()
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
        private void Permute(int[] nums, int start, List<int[]> result)
        {
            if (start == nums.Length - 1)
            {
                int[] copy = new int[nums.Length];
                Array.Copy(nums, copy, nums.Length);
                result.Add(copy);
            }
            else
            {
                for (int i = start; i < nums.Length; i++)
                {
                    Swap(nums, start, i);
                    Permute(nums, start + 1, result);
                    Swap(nums, start, i);
                }
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        private void Task_2_Click(object sender, RoutedEventArgs e)
        {
            int[] nums = { 1, 2, 3 };
            List<int[]> result = new List<int[]>();
            Permute(nums, 0, result);

            StringBuilder sb = new StringBuilder();
            foreach (int[] perm in result)
            {
                sb.AppendLine(string.Join(" ", perm));
            }

            textBox1.Text = sb.ToString();

        }
    }
}