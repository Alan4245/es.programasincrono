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
using System.Threading;
using System.IO;

namespace Es.Programma_Asincrono
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Dichiario gli uri, le imagesource e le variabili necessarie.
        Uri uriDado1;
        Uri uriDado2;
        Uri uriDado3;
        Uri uriDado4;
        Uri uriDado5;
        Uri uriDado6;
        ImageSource dado1;
        ImageSource dado2;
        ImageSource dado3;
        ImageSource dado4;
        ImageSource dado5;
        ImageSource dado6;
        Random r;
        int i;
        int f;
        int totalCharacters;
        int progressoProgressBar;

        public MainWindow()
        {
            //Inizializzo la mainwindow e istanzio i dati precedentemente dichiarati.
            InitializeComponent();
            uriDado1 = new Uri("Dado1.png", UriKind.Relative);
            uriDado2 = new Uri("Dado2.png", UriKind.Relative);
            uriDado3 = new Uri("Dado3.png", UriKind.Relative);
            uriDado4 = new Uri("Dado4.png", UriKind.Relative);
            uriDado5 = new Uri("Dado5.png", UriKind.Relative);
            uriDado6 = new Uri("Dado6.png", UriKind.Relative);
            dado1 = new BitmapImage(uriDado1);
            dado2 = new BitmapImage(uriDado2);
            dado3 = new BitmapImage(uriDado3);
            dado4 = new BitmapImage(uriDado4);
            dado5 = new BitmapImage(uriDado5);
            dado6 = new BitmapImage(uriDado6);
            r = new Random();
            i = 0;
            f = 0;
            totalCharacters = 0;
            progressoProgressBar = 0;
            pgb1.Minimum = 0;
            pgb1.Maximum = 500;
            SorteggioInfinito();
            
        }

        public async void SorteggioInfinito()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(500);
                    i = r.Next(1, 7);
                    f = r.Next(1, 7);

                    switch (i)
                    {
                        case 1:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado1.Source = dado1;
                            }));
                            break;
                        case 2:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado1.Source = dado2;
                            }));
                            break;
                        case 3:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado1.Source = dado3;
                            }));
                            break;
                        case 4:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado1.Source = dado4;
                            }));
                            break;
                        case 5:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado1.Source = dado5;
                            }));
                            break;
                        case 6:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado1.Source = dado6;
                            }));
                            break;
                        default:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado1.Source = dado1;
                            }));
                            break;
                    }

                    switch (f)
                    {
                        case 1:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado2.Source = dado1;
                            }));
                            break;
                        case 2:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado2.Source = dado2;
                            }));
                            break;
                        case 3:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado2.Source = dado3;
                            }));
                            break;
                        case 4:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado2.Source = dado4;
                            }));
                            break;
                        case 5:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado2.Source = dado5;
                            }));
                            break;
                        case 6:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado2.Source = dado6;
                            }));
                            break;
                        default:
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                imgDado2.Source = dado1;
                            }));
                            break;
                    }
                }
            });
        }

        public async void LetturaFile()
        {
            await Task.Run(() =>
            {

                using(StreamReader sr = new StreamReader("Data.txt"))
                {
                    string textFile = sr.ReadToEnd();
                    totalCharacters = textFile.Length;
                }

            });
        }

        public async void ProgressBar()
        {
            await Task.Run(() =>
            {
                int lel = 0;
                double risStampa = 0;
                while (progressoProgressBar < 500)
                {
                    Thread.Sleep(1000);
                    lel += r.Next(0, 25);

                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        if (lel < 500)
                        {
                            progressoProgressBar = lel;
                            pgb1.Value = lel;
                            risStampa = (lel * 100) / 500;
                            lblOutputCaricamento.Content = ("In lettura: " + risStampa);
                        }
                        else
                        {
                            progressoProgressBar = 500;
                            pgb1.Value = 500;
                            lblOutputCaratteri.Content = ("I caratteri totali sono: " + totalCharacters);
                            lblOutputCaricamento.Content = "Lettura completata";
                        }
                    }));
                }
            });
        }

        private void btnEstrai_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Il risultato è: " + (i + f));

        }
    }
}
