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

        }
    }
}
