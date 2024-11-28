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
using System.Windows.Shapes;

namespace Kt_halava
{
    /// <summary>
    /// Логика взаимодействия для Foto.xaml
    /// </summary>
    public partial class Foto : Window
    {
        public Foto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /* Random rnd = new Random();
             byte firstId;
             byte secondId;
             byte thirdId;

             byte[] bytes = new byte[255];

             firstId = rnd.NextBytes(bytes);
             secondId = rnd.NextBytes(bytes);
             thirdId = rnd.NextBytes(bytes);

             Color myRgbColor = new Color();
             myRgbColor = Color.FromRgb(firstId, secondId, thirdId);
             SolidColorBrush col = new SolidColorBrush();



             this.Background = col.Color;

             Background = Brushes.Black;     
             */



        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            first.IsChecked = true;

            string imagePath = "C:/Users/Tsyganovsp/source/repos/Kt halava/Kt halava/image/1.jpg";
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
            DisplayImage.Source = bitmap;
        }

        private void Second_Checked(object sender, RoutedEventArgs e)
        {
            second.IsChecked = true;

            string imagePath = "C:/Users/Tsyganovsp/source/repos/Kt halava/Kt halava/image/2.jpg";
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
            DisplayImage.Source = bitmap;
        }

        private void Third_Checked(object sender, RoutedEventArgs e)
        {
            third.IsChecked = true;

            string imagePath = "C:/Users/Tsyganovsp/source/repos/Kt halava/Kt halava/image/3.jpg";
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
            DisplayImage.Source = bitmap;
        }
    }
}
