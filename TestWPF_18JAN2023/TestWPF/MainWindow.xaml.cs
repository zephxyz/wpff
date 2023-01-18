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

namespace TestWPF
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

        List<Clovek> listik = new List<Clovek>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "data files (*.txt)|*.txt";
            openFileDialog.FileName = "1.txt";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream soub = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(soub, Encoding.ASCII))
                    {
                        nejvice.Foreground = Brushes.Black;
                        nejmene.Content = "";
                        avg.Content = "";
                        second.Content = "";
                        string text;
                        string jmeno = "";
                        string plat = "";
                        int i = 0;
                        while ((text = sr.ReadLine()) != null)
                        {
                            i = 0;
                            jmeno = "";
                            plat = "";
                            while (text[i] != ';')
                            {
                                if (text[i] == ' ')
                                {
                                    i++;
                                    continue;
                                }    
                                jmeno += text[i++];
                            }
                            for (int j = i+1; j < text.Length; j++)
                            {
                                if (text[j] == ' ')
                                {
                                    continue;
                                }
                                plat += text[j];
                               
                            }
                            if(!int.TryParse(plat, out int x))
                            {
                                nejvice.Content = "CHYBA, ŠPATNÝ FORMÁT";
                                nejvice.Foreground = Brushes.Red;
                                return;
                            }    
                            listik.Add(new Clovek(jmeno, x));
                        }
                        listik = bsort(listik);
                        
                        

                        nejvice.Content = "Nejvíce peněz má " + listik[0].name + " (" + listik[0].plat + " Kč)";
                        nejmene.Content = "Nejméně peněz má " + listik[listik.Count - 1].name + " (" + +listik[listik.Count - 1].plat + " Kč)";
                        avg.Content = "Průměr je: " + Prumer(listik) + " Kč";
                        second.Content = "Jako druhý měl nejvíc peněz " + listik[1].name + " (" + listik[1].plat + " Kč)";
                    }
                }
            }
        }

        static List<Clovek> bsort(List<Clovek> listik)
        {
            for (int l = 0; l < listik.Count; l++)
            {
                for (int u = listik.Count - 1; u > 0; u--)
                {
                    Clovek temp;
                    if (listik[u].plat > listik[u - 1].plat)
                    {
                        temp = listik[u];
                        listik[u] = listik[u - 1];
                        listik[u - 1] = temp;
                    }
                }
            }
            return listik;
        }

        static int Prumer(List<Clovek> listik)
        {
            int i = 0;
            for (int j = 0; j < listik.Count; j++)
            {
                i += listik[j].plat;
            }

            return i/listik.Count;
        }
    }

    class Clovek
    {
        public string name;
        public int plat;

        public Clovek(string name, int plat)
        {
            this.name = name;
            this.plat = plat;
        }
    }
}
