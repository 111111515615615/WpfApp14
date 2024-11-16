using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем размер матрицы
                int M = int.Parse(RowsTextBox.Text);
                int N = int.Parse(ColumnsTextBox.Text);

                // Получаем строку, для которой нужно найти сумму и произведение
                int K = int.Parse(RowNumberTextBox.Text);

                // Проверяем, что K находится в допустимом диапазоне
                if (K < 1 || K > M)
                {
                    MessageBox.Show("Номер строки K должен быть в диапазоне от 1 до M.");
                    return;
                }

                // Создаем матрицу
                int[,] matrix = new int[M, N];

                // Заполняем матрицу значениями из TextBox
                string[] inputValues = InputTextBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int index = 0;
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        matrix[i, j] = int.Parse(inputValues[index++]);
                    }
                }

                // Вычисляем сумму и произведение элементов K-й строки
                int sum = 0;
                int product = 1;
                for (int j = 0; j < N; j++)
                {
                    sum += matrix[K - 1, j]; // K-й строке соответствует индекс K-1
                    product *= matrix[K - 1, j];
                }

                // Выводим результаты
                SumTextBlock.Text = $"Сумма элементов {K}-й строки: {sum}";
                ProductTextBlock.Text = $"Произведение элементов {K}-й строки: {product}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
namespace MatrixSumProduct
{
    public partial class MainWindow : Window
    {
    }
}
//424242424
    