using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace cf
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class explorer : Page
    {
        private List<TranslateTransform> dragTranslation;
        int count = 0;
        List<bool> garv = new List<bool> { false, false, false, false, false, false };
        chitra clicked_chitra = new chitra { ID = "", Labels = new List<naam> { new naam { kyahai = "", x = 0, x_ = 0, y = 0, y_ = 0 } } };
        public explorer()
        {
            this.InitializeComponent();
            dragTranslation = new List<TranslateTransform>();
            for (int u = 0; u < 6; ++u) dragTranslation.Add(new TranslateTransform());
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string x = "";
            if (e != null)
                x = e.Parameter.ToString();
            img.Source = new BitmapImage(new Uri(x, UriKind.Absolute));
            List<Windows.UI.Xaml.Shapes.Rectangle> rects = new List<Windows.UI.Xaml.Shapes.Rectangle>();
            rects.Add(rect1);
            rects.Add(rect2);
            rects.Add(rect3);
            rects.Add(rect4);
            rects.Add(rect5);
            rects.Add(rect6);
            List<naam> saare_naam = new List<naam>();
            saare_naam.Clear();
            List<TextBlock> texts = new List<TextBlock>();
            texts.Add(label1);
            texts.Add(label2);
            texts.Add(label3);
            texts.Add(label4);
            texts.Add(label5);
            texts.Add(label6);
            foreach (Rectangle r in rects)
            { r.Visibility = Visibility.Collapsed; }
            foreach (TextBlock t in texts)
            { t.Visibility = Visibility.Collapsed; }
            if (x.Contains("1.jpg"))
            {
                string id = "IMG1";
                saare_naam.Add(new naam { kyahai = "Speaker", x = 552, y = 728 });
                saare_naam.Add(new naam { kyahai = "Keyboard", x = 489, y = 602 });
                saare_naam.Add(new naam { kyahai = "Mouse", x = 815, y = 552 });
                saare_naam.Add(new naam { kyahai = "Monitor", x = 723, y = 0 });
                saare_naam.Add(new naam { kyahai = "CPU", x = 970, y = 41 });
                clicked_chitra = new chitra { ID = id, Labels = saare_naam };
            }
            if (x.Contains("2.jpg"))
            {
                string id = "IMG2";
                saare_naam.Add(new naam { kyahai = "Sepals", x = 750, y = 566 });
                saare_naam.Add(new naam { kyahai = "Petals", x = 299, y = 282 });
                saare_naam.Add(new naam { kyahai = "Ovary", x = 867, y = 288 });
                saare_naam.Add(new naam { kyahai = "Ovule", x = 363, y = 418 });
                saare_naam.Add(new naam { kyahai = "Steman", x = 888, y = 216 });
                saare_naam.Add(new naam { kyahai = "Pistol", x = 441, y = 157 });
                clicked_chitra = new chitra { ID = id, Labels = saare_naam };
            }
            if (x.Contains("3.jpg"))
            {
                string id = "IMG3";
                saare_naam.Add(new naam { kyahai = "Battery", x = 369, y = 357 });
                saare_naam.Add(new naam { kyahai = "Ammeter", x = 745, y = 347 });
                saare_naam.Add(new naam { kyahai = "Resistor", x = 500, y = 246 });
                saare_naam.Add(new naam { kyahai = "Switch", x = 530, y = 552 });
                clicked_chitra = new chitra { ID = id, Labels = saare_naam };
            }
            if (x.Contains("4.jpg"))
            {
                string id = "IMG4";
                saare_naam.Add(new naam { kyahai = "AND", x = 256, y = 268 });
                saare_naam.Add(new naam { kyahai = "NAND", x = 260, y = 600 });
                saare_naam.Add(new naam { kyahai = "OR", x = 834, y = 268 });
                saare_naam.Add(new naam { kyahai = "NOT", x = 892, y = 597 });
                clicked_chitra = new chitra { ID = id, Labels = saare_naam };
            }
            if (x.Contains("5.jpg"))
            {
                string id = "IMG5";
                saare_naam.Add(new naam { kyahai = "Brain", x = 753, y = 10 });
                saare_naam.Add(new naam { kyahai = "Lungs", x = 784, y = 355 });
                saare_naam.Add(new naam { kyahai = "Stomach", x = 787, y = 440 });
                saare_naam.Add(new naam { kyahai = "Liver", x = 790, y = 508 });
                saare_naam.Add(new naam { kyahai = "Intestine", x = 790, y = 580 });
                clicked_chitra = new chitra { ID = id, Labels = saare_naam };
            }
            if (x.Contains("6.jpg"))
            {
                string id = "IMG6";
                saare_naam.Add(new naam { kyahai = "Artic", x = 550, y = 14 });
                saare_naam.Add(new naam { kyahai = "Atlantic", x = 387, y = 284 });
                saare_naam.Add(new naam { kyahai = "Indian", x = 802, y = 440 });
                saare_naam.Add(new naam { kyahai = "Pacific", x = 1073, y = 332 });
                saare_naam.Add(new naam { kyahai = "Southern", x = 823, y = 608 });
                clicked_chitra = new chitra { ID = id, Labels = saare_naam };
            }
            if (x.Contains("7.jpg"))
            {
                string id = "IMG7";
                saare_naam.Add(new naam { kyahai = "Joomla", x = 220, y = 258 });
                saare_naam.Add(new naam { kyahai = "Apple", x = 656, y = 324 });
                saare_naam.Add(new naam { kyahai = "WordPress", x = 1080, y = 246 });
                saare_naam.Add(new naam { kyahai = "Microsoft", x = 183, y = 644 });
                saare_naam.Add(new naam { kyahai = "Drupal", x = 657, y = 646 });
                saare_naam.Add(new naam { kyahai = "Android", x = 1100, y = 643 });
                clicked_chitra = new chitra { ID = id, Labels = saare_naam };
            }
            for (int i = 0; i < saare_naam.Count; ++i)
            {
                rects[i].Visibility = Visibility.Visible;
                rects[i].RenderTransformOrigin = new Point(0, 0);
                TranslateTransform tt = new TranslateTransform();
                tt.X = saare_naam[i].x - (Window.Current.Bounds.Right / 2);
                tt.Y = saare_naam[i].y - (Window.Current.Bounds.Bottom / 2) + 20;
                rects[i].RenderTransform = tt;
                texts[i].Visibility = Visibility.Visible;
                texts[i].Margin = new Thickness(10, 45 * (i + 1), 0, 0);
                texts[i].Text = saare_naam[i].kyahai;
                dragTranslation[i].X += 150 - Window.Current.Bounds.Right / 2;
                dragTranslation[i].Y += 200 - Window.Current.Bounds.Bottom / 2 + (i * 10);
                texts[i].RenderTransform = dragTranslation[i];
                texts[i].ManipulationCompleted += async delegate
                {
                    for (int j = 0; j < i; ++j)
                    {
                        var ttv = texts[j].TransformToVisual(Window.Current.Content);
                        Point c = ttv.TransformPoint(new Point(0, 0));
                        if (c.X > Window.Current.Bounds.Right)
                        {
                            dragTranslation[j].X -= c.X;
                        }
                        if (c.X < Window.Current.Bounds.Left)
                        {
                            dragTranslation[j].X -= c.X;
                            dragTranslation[j].X += (Window.Current.Bounds.Right - 100);
                        }
                        if (c.Y > Window.Current.Bounds.Bottom - 5)
                        {
                            dragTranslation[j].Y -= c.Y;
                            dragTranslation[j].Y += (Window.Current.Bounds.Top + 20);
                        }
                        if (c.Y < Window.Current.Bounds.Top - 5)
                        {
                            dragTranslation[j].Y += (-c.Y);
                            dragTranslation[j].Y += (Window.Current.Bounds.Bottom - 50);
                        }
                        SolidColorBrush lol = new SolidColorBrush(Colors.Green);
                        var ttv2 = rects[j].TransformToVisual(Window.Current.Content);
                        Point c2 = ttv2.TransformPoint(new Point(0, 0));
                        if (c.X >= c2.X && c.X <= (c2.X + rects[j].ActualWidth))
                        {
                            if (c.Y >= c2.Y && c.Y <= (c2.Y + rects[j].ActualHeight))
                            {
                                if (j == 0) { texts[j].ManipulationDelta -= explorer_ManipulationDelta1; garv[0] = true; }
                                if (j == 1) { texts[j].ManipulationDelta -= explorer_ManipulationDelta2; garv[1] = true; }
                                if (j == 2) { texts[j].ManipulationDelta -= explorer_ManipulationDelta3; garv[2] = true; }
                                if (j == 3) { texts[j].ManipulationDelta -= explorer_ManipulationDelta4; garv[3] = true; }
                                if (j == 4) { texts[j].ManipulationDelta -= explorer_ManipulationDelta5; garv[4] = true; }
                                if (j == 5) { texts[j].ManipulationDelta -= explorer_ManipulationDelta6; garv[5] = true; }
                                if (texts[j].Foreground != lol)
                                {
                                    dragTranslation[j].X -= c.X - c2.X - 5;
                                    dragTranslation[j].Y += c2.Y - c.Y + 5;
                                    texts[j].Foreground = new SolidColorBrush(Colors.Green);
                                }
                                else
                                {

                                }
                            }
                            else texts[j].Foreground = new SolidColorBrush(Colors.Red);
                        }
                        else texts[j].Foreground = new SolidColorBrush(Colors.Red);
                    }
                    int u = 0;
                    for (u = 0; u < i; ++u) { if (garv[u] == false)break; }
                    if (u == i)
                    {
                        MessageDialog md = new MessageDialog("You are the most genius person on this planet!", "Congratulations");
                        UICommand okay = new UICommand("Thanks"); okay.Invoked += delegate { Frame.Navigate(typeof(MainPage)); };
                        md.Commands.Add(okay); await md.ShowAsync();
                    }
                };
                if (i == 0) texts[i].ManipulationDelta += explorer_ManipulationDelta1;
                if (i == 1) texts[i].ManipulationDelta += explorer_ManipulationDelta2;
                if (i == 2) texts[i].ManipulationDelta += explorer_ManipulationDelta3;
                if (i == 3) texts[i].ManipulationDelta += explorer_ManipulationDelta4;
                if (i == 4) texts[i].ManipulationDelta += explorer_ManipulationDelta5;
                if (i == 5) texts[i].ManipulationDelta += explorer_ManipulationDelta6;
            }
        }

        void explorer_ManipulationDelta1(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            dragTranslation[0].X += e.Delta.Translation.X;
            dragTranslation[0].Y += e.Delta.Translation.Y;
            // if (dragTranslation[0].X > Window.Current.Bounds.Right) dragTranslation[0].X = 0;
            //  if (dragTranslation[0].X < Window.Current.Bounds.Left) dragTranslation[0].X = Window.Current.Bounds.Right;
            // if (dragTranslation[0].X > Window.Current.Bounds.Bottom) dragTranslation[0].Y = 0;
            // if (dragTranslation[0].X < Window.Current.Bounds.Top) dragTranslation[0].Y = Window.Current.Bounds.Bottom;
        }
        void explorer_ManipulationDelta2(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            dragTranslation[1].X += e.Delta.Translation.X;
            dragTranslation[1].Y += e.Delta.Translation.Y;
        }
        void explorer_ManipulationDelta3(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            dragTranslation[2].X += e.Delta.Translation.X;
            dragTranslation[2].Y += e.Delta.Translation.Y;
        }
        void explorer_ManipulationDelta4(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            dragTranslation[3].X += e.Delta.Translation.X;
            dragTranslation[3].Y += e.Delta.Translation.Y;
        }
        void explorer_ManipulationDelta5(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            dragTranslation[4].X += e.Delta.Translation.X;
            dragTranslation[4].Y += e.Delta.Translation.Y;
        }
        void explorer_ManipulationDelta6(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            dragTranslation[5].X += e.Delta.Translation.X;
            dragTranslation[5].Y += e.Delta.Translation.Y;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
