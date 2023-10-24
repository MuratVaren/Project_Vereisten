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


namespace Project_Vereisten
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
            TxtBloemNaam.Text = "Rozen";
            TxtBloemPrijs.Text = "€30";
        }

        private void ImgLavender_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtBloemNaam.Text = "Lavender";
            TxtBloemPrijs.Text = "€10";
        }

        private void ImgGoudsbloem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtBloemNaam.Text = "Goudsbloem";
            TxtBloemPrijs.Text = "€3";
        }

        private void ImgWilkens_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtBloemNaam.Text = "Wilkens bitter";
            TxtBloemPrijs.Text = "€15";
        }
    }
}
