using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Syncfusion;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace cf
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Imag> Imags;
        public MainPage()
        {
            this.InitializeComponent();
            Imags = new List<Imag>();
            Imags.Add(new Imag { src = "/Assets/1.jpg" });
            Imags.Add(new Imag { src = "/Assets/2.jpg" });
            Imags.Add(new Imag { src = "/Assets/3.jpg" });
            Imags.Add(new Imag { src = "/Assets/4.jpg" });
            Imags.Add(new Imag { src = "/Assets/5.jpg" });
            Imags.Add(new Imag { src = "/Assets/6.jpg" });
            Imags.Add(new Imag { src = "/Assets/7.jpg" });

            carousel.ItemsSource = Imags;
        }

        private void OpenPages(object sender, TappedRoutedEventArgs e)
        {
             Image image_clicked = sender as Image;
     
          string src1 = ((BitmapImage)image_clicked.Source).UriSource.ToString();
           Frame.Navigate(typeof(explorer), src1);
        }

        private void SfCarouselItem_Selected(object sender, RoutedEventArgs e)
        {
            
        }
        public class Imag
        {
            public string src { get; set; }
        }

        private void carousel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // var v = sender as Syncfusion.SfCarousel.Universal.Syncfusion_SfCarousel_Universal_2013_XamlTypeInfo.XamlMetaDataProvider;
        }
    }
}
