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

namespace WpfApp10
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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                
            }
        }


        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            double sirka = gr.ActualWidth;

            Rectangle rc = new Rectangle();
            rc.Fill = Brushes.Aqua;
            rc.Margin = new Thickness();
        }
    }
}
