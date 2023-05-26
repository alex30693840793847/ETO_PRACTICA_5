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

namespace Zadanie4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(DOUBLEX.Text);
                int n = int.Parse(INTN.Text);
                double result = 0;
                int s = 1;
                double fact = 1;

                for (int i = 1; i <= n; i++)
                {
                    result += s * Math.Pow(x, 2 * i - 1) / fact;
                    s *= -1;
                    fact *= (2 * i) * (2 * i + 1);
                }

                OTV.Text = $"Результат: {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
