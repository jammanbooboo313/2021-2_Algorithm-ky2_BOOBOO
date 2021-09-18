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

namespace A002_Factorial
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtNo.Text);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            long rfact = rFactorial(x); //재귀함수
            watch.Stop();
            //수행시간 Ticks 단위로 알려준다.
            var elap = watch.ElapsedTicks;
            string result = "Ticks = " + elap; //여기까지 시간측정 코드 교수님도 못 외움
            listbox.Items.Add(result);//시간출력부분



            watch = System.Diagnostics.Stopwatch.StartNew();
            long fact = Factorial(x); //반복문
            watch.Stop();
            //수행시간 Ticks 단위로 알려준다.
            elap = watch.ElapsedTicks;
            result = "Ticks = " + elap; //여기까지 시간측정 코드 교수님도 못 외움
            listbox.Items.Add(result);//시간출력부분


            listbox.Items.Add("Recursive : " + rfact);
            listbox.Items.Add("반복문 : " + fact);

        }

        private long Factorial(int x)
        {
            long f = 1;
            for (int i = 2; i <= x; i++)
            {
                f *= i;
            }
            return f;
        }

        
        private long rFactorial(long x)
        {
            if (x == 1)
                return 1;
            else
                return rFactorial(x - 1) * x;
        }
    }
}
