using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp8
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == btsave)
            {
                System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.Filter = "data files (*.txt)|*.txt";
                saveFileDialog.FileName = "Pokus.txt";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (Stream soub = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(soub, Encoding.ASCII))
                        {
                            for (int i = 1; i <= 10; i++)
                            {
                                sw.WriteLine(i);
                            }
                        }
                    }
                }
            }
            else
            {
                System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "data files (*.txt)|*.txt";
                openFileDialog.FileName = "Pokus.txt";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (Stream soub = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader sr = new StreamReader(soub, Encoding.ASCII))
                        {
                            string text;
                            while ((text = sr.ReadLine()) != null)
                            {
                                lbtext.Content += text;
                            }
                        }
                    }
                }
            }   
        }
    }
}
