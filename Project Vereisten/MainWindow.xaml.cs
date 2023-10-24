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
using System.Xml;

namespace Project_Vereisten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string taal;
        public MainWindow()
        {
            InitializeComponent();
            taal = "nl";
        }

        private void Imgrozen_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush solidColorBrush = new SolidColorBrush(Colors.Red);
            this.Background = solidColorBrush;
        }

        private void ImgLavender_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush solidColorBrush = new SolidColorBrush(Colors.Purple);
            this.Background = solidColorBrush;
        }

        private void ImgGoudsbloem_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush solidColorBrush = new SolidColorBrush(Colors.Orange);
            this.Background = solidColorBrush;
        }

        private void ImgWilkens_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush solidColorBrush = new SolidColorBrush(Colors.Yellow);
            this.Background = solidColorBrush;
        }

        private void Img_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush solidColorBrush = new SolidColorBrush(Colors.LightGray);
            this.Background = solidColorBrush;
        }

        private void Imgrozen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(taal == "nl")
            {
                TxtBloemNaam.Text = "Rozen";

            }
            else
            {
                TxtBloemNaam.Text = "Roses";
            }
            TxtBloemPrijs.Text = "€30";
        }

        private void ImgLavender_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(taal == "nl")
            {
                TxtBloemNaam.Text = "Lavendel";
            }
            else
            {
                TxtBloemNaam.Text = "Lavender";

            }
            TxtBloemPrijs.Text = "€10";
        }

        private void ImgGoudsbloem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(taal == "nl")
            {
                TxtBloemNaam.Text = "Goudsbloem";
            }
            else
            {
                TxtBloemNaam.Text = "Marigold";
            }
            TxtBloemPrijs.Text = "€3";
        }

        private void ImgWilkens_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(taal == "nl")
            {
                TxtBloemNaam.Text = "Wilkens bitter";
            }
            else
            {
                TxtBloemNaam.Text = "Golden trumpet";

            }
            TxtBloemPrijs.Text = "€15";
        }

        private void BtnNL_Click(object sender, RoutedEventArgs e)
        {
            taal = "nl";
            TxtBloemwinkel.Text = "Bloemenwinkel Selectie Mimosa";
            TxtBloemNaam.Text = string.Empty;
            TxtBloemPrijs.Text = string.Empty;
        }

        private void BtnEN_Click(object sender, RoutedEventArgs e)
        {
            taal = "en";
            TxtBloemwinkel.Text = "Flowershop Selection Mimosa";
            TxtBloemNaam.Text = string.Empty;
            TxtBloemPrijs.Text = string.Empty;
        }
    }
}
