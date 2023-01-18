using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp9
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Data data = new Data();
        public MainWindow()
        {
            InitializeComponent();
        }


        int count;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            data.Data1 = count;
            Window1 window1 = new Window1(data);
            window1.Show();
        }
    }
}
