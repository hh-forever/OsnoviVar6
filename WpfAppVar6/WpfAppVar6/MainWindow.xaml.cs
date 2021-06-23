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

namespace WpfAppVar6
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
            this.Close();
        }

        private static int MaxValue(int a, int x, int y, int z)
        {
            return (Math.Max(a, Math.Max(x, Math.Max(y, z))));
        }

        private void Button_Reschenie(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(Number1.Text);
            int x = Convert.ToInt32(Number2.Text);
            int y = Convert.ToInt32(Number3.Text);
            int z = Convert.ToInt32(Number4.Text);

            NumberMax.Text = MaxValue(a, x, y, z).ToString();

        }
    }
}
