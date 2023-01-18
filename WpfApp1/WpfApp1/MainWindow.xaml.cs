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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<int> ints = new List<int>();
        public int last = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Gen(new Random());
        }

        private void Gen(Random rng)
        {
           
            topleft.Visibility = Visibility.Hidden;
            midleft.Visibility = Visibility.Hidden;
            botleft.Visibility = Visibility.Hidden;
            midmid.Visibility = Visibility.Hidden;
            topright.Visibility = Visibility.Hidden;
            midright.Visibility = Visibility.Hidden;
            botright.Visibility = Visibility.Hidden;

            int x = rng.Next(1, 7);
            ints.Add(x);
            while (x == last)
                x = rng.Next(1, 7);

            switch (x)
            {
                case 1:
                    midmid.Visibility = 0;
                    break; 
                case 2:
                    botleft.Visibility = 0;
                    topright.Visibility = 0;
                    break;
                case 3:
                    botleft.Visibility = 0;
                    topright.Visibility = 0;
                    midmid.Visibility = 0;
                    break;
                case 4:
                    botleft.Visibility = 0;
                    topright.Visibility = 0;
                    topleft.Visibility = 0;
                    botright.Visibility = 0;
                    break;
                case 5:
                    midmid.Visibility = 0;
                    botleft.Visibility = 0;
                    topright.Visibility = 0;
                    topleft.Visibility = 0;
                    botright.Visibility = 0;
                    break;
                case 6:
                    botleft.Visibility = 0;
                    topright.Visibility = 0;
                    topleft.Visibility = 0;
                    botright.Visibility = 0;
                    midleft.Visibility = 0;
                    midright.Visibility = 0;

                    break;

            }
            last = x;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
