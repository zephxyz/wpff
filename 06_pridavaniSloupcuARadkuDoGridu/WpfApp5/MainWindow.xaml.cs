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

namespace WpfApp5
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

        SolidColorBrush barva = Brushes.LightCyan;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == first)
                barva = Brushes.Blue;
            else if (sender == second)
                barva = Brushes.Gray;
            else if (sender == third)
                barva = Brushes.Green;
            else if (sender == fourth)
                barva = Brushes.Red;
            else if (sender == fifth)
                barva = Brushes.Pink;
               

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Gr.RowDefinitions.Add(new RowDefinition());
                Gr.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for(int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Rectangle rc = new Rectangle();
                    rc.Fill = Brushes.LightCyan;
                    Grid.SetRow(rc, j);
                    Grid.SetColumn(rc, i);
                    rc.Margin = new Thickness(2);
                    Gr.Children.Add(rc);
                    rc.MouseLeftButtonDown += Rc_MouseLeftButtonDown;

                }
            }
        }

        private void Rc_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Rectangle rc)
            {
                rc.Fill = barva;
            }
        }
    }
}
