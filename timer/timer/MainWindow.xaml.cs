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
using System.Windows.Threading;

namespace timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer(DispatcherPriority.Send);


            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += Timer_Tick;
            
        }

        int targetValue;
        int score = 0;
        bool up = false;

        bool increment = true;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (pb.Value == 0)
                increment = true;
            else if (pb.Value == 100)
                increment = false;
            if (increment)
            {
               pb.Value += 0.5;
            }       
            else
                pb.Value -= 0.5;
        }

        private void strt_Click(object sender, RoutedEventArgs e)
        {
            if (up)
                return;
            up = true;
            timer.Start();
            targetValue = Gen(new Random());
            cas.Content = "Cíl: " + targetValue;
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            if (!up)
                return;
            up = false;
            timer.Stop();
            score = Math.Abs((int)Math.Round(pb.Value) - targetValue);
            scr.Content = "Score: " + score;
            pb.Value = 0;
        }

        private int Gen(Random x)
        {
            return x.Next(0, 100);
        }
    }
}
