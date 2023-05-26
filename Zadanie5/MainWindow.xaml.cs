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

namespace Zadanie5
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
                double q = double.Parse(Q.Text);
                double r = double.Parse(R.Text);
                double b = double.Parse(B.Text);
                double c = double.Parse(C.Text);
                double d = double.Parse(D.Text);
                int n = int.Parse(N.Text);
                double x = 0, x0, x1;
                x0 = c; 
                x1 = d;
                for (int k = 2; k <= n; k++)
                {
                    x = q * x1 + r * x0 + b; 
                    x0 = x1; 
                    x1 = x; 
                }
                OTV.Text = $"Результат: x[{n}] = {x}";
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
