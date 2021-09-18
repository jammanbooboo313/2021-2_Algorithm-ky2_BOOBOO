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

namespace Fibonacci
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
            int n = int.Parse(txtNo.Text);
            listbox.Items.Clear();
            listbox.Items.Add("Recursive Fibonacci");

            //시간 측정 제귀이용
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 1; i <= n; i++)
            {
                listbox.Items.Add(Fibonacci(i));
            }
            watch.Stop();
            var elap = watch.ElapsedTicks; // 시간측정 제귀이용 끝
            listbox.Items.Add("Ticks = " + elap + ", ms : " + watch.ElapsedMilliseconds); // 제귀 이용 시간측정 출력

            //반복문으로 계산
            int[] fibo = new int[101];
            watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == 2)
                    fibo[i] = 1;
                else
                    fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            watch.Stop();
            elap = watch.ElapsedTicks; // 시간측정 반복문이용 끝


            listbox.Items.Add("loop Fibonacci");

            for (int i = 1; i <= n; i++) //리스트에 추가
            {
                listbox.Items.Add(fibo[i]);
            }

            listbox.Items.Add("Ticks = " + elap + ", ms : " + watch.ElapsedMilliseconds); // 반복문 이용 시간측정 출력

        }

        private int Fibonacci(int i)
        {
            if (i == 1 || i == 2)
                return 1;
            else
                return Fibonacci(i - 1) + Fibonacci(i - 2);
        }
    }
}
