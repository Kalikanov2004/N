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
using System.Windows.Navigation;
using System.Windows.Shapes;
 namespace ZeroCountWpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CountButton_Click(object sender, RoutedEventArgs e)
        {
            // Генерируем массив случайных чисел
            Random random = new Random();
            int N = 100; // Замените на нужное количество элементов
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = random.Next(0, 100);
            }

            // Находим количество нулевых элементов
            int count = 0;
            foreach (int element in array)
            {
                if (element == 0)
                {
                    count++;
                }
            }

            // Выводим результат в TextBlock
            ResultTextBlock.Text = $"Количество нулевых элементов: {count}";
        }
    }
}