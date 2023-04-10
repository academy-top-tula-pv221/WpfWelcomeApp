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
using System.ComponentModel;

namespace WpfWelcomeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Button btnHello = new();
            //btnHello.Width = 200;
            //btnHello.Height = 100;
            //btnHello.Content = "Press me";
            //btnHello.Background = new SolidColorBrush(Colors.Red);
            ////btnHello.Background = (Brush)TypeDescriptor.GetConverter(typeof(Brush))
            ////                                           .ConvertFromInvariantString("Red");

            //btnHello.Click += Button_Click;

            //grid.Children.Add(btnHello);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtBoxUser.Text.Trim();
            if (name != "")
                MessageBox.Show($"Hello {name}");
        }
    }
}
