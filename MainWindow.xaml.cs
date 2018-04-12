using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GaleryApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class GelleryItem {
            public string Source { get; set; }

            public double Angle { get; set; }

            public string Title { get; set; }

        }

        public void CloseHandle(object sender, RoutedEventArgs e)
        {
            var bor = (sender as ListBox);

            bor.SelectedIndex = -1;
        }

        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<GelleryItem> list = new ObservableCollection<GelleryItem>();

            list.Add(new GelleryItem() {
                Source = "/Images/img1.jpg",
                Title = "Картинка 1",
                Angle = -15,
                
            });

            list.Add(new GelleryItem()
            {
                Source = "/Images/img2.jpg",
                Title = "Картинка 2",
                Angle = 0
            });

            list.Add(new GelleryItem()
            {
                Source = "/Images/img3.jpg",
                Title = "Картинка 3",
                Angle = 15
            });

            list.Add(new GelleryItem()
            {
                Source = "/Images/img4.jpg",
                Title = "Картинка 4",
                Angle = 30
            });


            Gellery.ItemsSource = list;

            
        }


    }
}
