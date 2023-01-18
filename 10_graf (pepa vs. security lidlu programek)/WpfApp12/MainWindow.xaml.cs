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
using LiveCharts;
using LiveCharts.Wpf;

namespace WpfApp12
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public LineSeries _lineSeries1 { get; set; }
        public LineSeries _lineSeries2 { get; set; }
        public LineSeries _lineSeries3 { get; set; }
        public LineSeries _lineSeries4 { get; set; }
        public SeriesCollection SCGraf { get; set; }

        public bool flatline1 = false;
        public bool flatline2 = false;
        private Random x = new Random();

        public int hornimez = 255;
        public int dolnimez = -255;

        DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Send);
        public MainWindow()
        {
            InitializeComponent();
            ChartValues<double> GrData1 = new ChartValues<double>();
            ChartValues<double> GrData2 = new ChartValues<double>();
            ChartValues<double> GrData3 = new ChartValues<double>();
            ChartValues<double> GrData4 = new ChartValues<double>();
            timer.Interval = TimeSpan.FromMilliseconds(0.5);
            timer.Tick += (sender, args) => 
            {
                if (!flatline1)
                {
                    GrData1.Add(x.Next(dolnimez, hornimez));
                    if (x.Next(0, 1000) == 1 && !flatline2)
                    {
                        flatline1 = true;
                        dolnimez = -120;
                        hornimez = 120;
                    }
                       
                }
                else
                {
                    GrData1.Add(0);
                }
                if (!flatline2)
                {
                    GrData2.Add(x.Next(dolnimez, hornimez));
                    if (x.Next(0, 1000) == 1 && !flatline1)
                    {
                        flatline2 = true;
                        dolnimez = -120;
                        hornimez = 120;
                    }
                }
                else
                {
                    GrData2.Add(0);
                }
                GrData3.Add(300);
                GrData4.Add(-300);


                if (GrData1.Count() <= 100) return;
                GrData1.RemoveAt(0);
                GrData2.RemoveAt(0);
                GrData3.RemoveAt(0);
                GrData4.RemoveAt(0);
            };
            timer.Start();
            
            _lineSeries1 = new LineSeries
            {
                Title = "Securiťák heartbeat",
                Values = GrData1,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Black,
                PointGeometry = null
        };

            _lineSeries2 = new LineSeries
            {
                Title = "Pepa heartbeat",
                Values = GrData2,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Red,
                PointGeometry = null
            };

            _lineSeries3 = new LineSeries
            {
                Title = null,
                Values = GrData3,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Transparent,
                PointGeometry = null
            };
            _lineSeries4 = new LineSeries
            {
                Title = null,
                Values = GrData4,
                Fill = Brushes.Transparent,
                Stroke = Brushes.Transparent,
                PointGeometry = null
            };

            SCGraf = new SeriesCollection
            {
                _lineSeries1,
                _lineSeries2,
                _lineSeries3,
                _lineSeries4
            };

            DataContext = this;


        }

        
    }
}
