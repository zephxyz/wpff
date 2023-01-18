using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        public MainWindow()
        {
            
            InitializeComponent();
            
           
        }
        bool hrac = true;
        private void A_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button bt)
            {
                if(bt.Content.ToString() != "X" && bt.Content.ToString() != "O")
                {
                    if (hrac)
                    {
                        bt.Background = Brushes.Blue;
                        bt.Content = "X";
                        hrac = false;
                    }
                    else
                    {
                        bt.Background = Brushes.Red;
                        bt.Content = "O";
                        hrac = true;
                    }    
                }
            }
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title = grid.ActualWidth.ToString();
            double sirka = grid.ActualWidth / 10;
            double vyska = grid.ActualHeight / 10;
            for (double i = 0; i < grid.ActualHeight; i+=vyska)
            {
                for (double j = 0; j < grid.ActualWidth; j+=sirka)
                {
                    Button a = new Button();
                    a.Width = sirka;
                    a.Height = vyska;
                    a.FontSize = 18;
                    a.Content = " ";
                    a.VerticalAlignment = VerticalAlignment.Top;
                    a.HorizontalAlignment = HorizontalAlignment.Left;
                    a.Margin = new Thickness(j, i, 0, 0);
                    a.Click += A_Click;
                    grid.Children.Add(a);
                }
            }
           

           
        }
    }
}
