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

namespace WpfApp1
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
        private void calculate_click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(X.Text);
            double y = x - (Math.Pow(x, 3) / 3) + Math.Pow(x, 5) / 5;
            result.Content = $"{Math.Round(y, 5)}";
        }

    }
}
