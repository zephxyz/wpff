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
using LiveCharts;
using LiveCharts.Wpf;



namespace WpfApp11
{

    
    public partial class CartesianChart
    {
        ChartValues<double> GrData1;
        public LineSeries _lineSeries1 { get; set; }
        public SeriesCollection SCgraf { get; set; }
        public CartesianChart()
        {
            InitializeComponent();
        }
    }
        
}