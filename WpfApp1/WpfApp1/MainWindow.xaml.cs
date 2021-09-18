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
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtNo1.Text);
            int y = int.Parse(txtNo2.Text);
            int gcd = Euclide(x, y);
            txtResult.Text = "최대공약수는 = " + gcd.ToString();


        }

        private int Euclide(int x, int y)
        {
            if (y == 0)
                return x;
            else
               return Euclide(y, x % y);

        }
    }
}
