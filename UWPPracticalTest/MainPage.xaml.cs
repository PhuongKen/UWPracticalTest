using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPPracticalTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            collection = new ObservableCollection<RootObject>();
            this.DataContext = this;
        }

        public ObservableCollection<RootObject> collection { get; set; }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {

            List<RootObject> data = await POJO.GetData();
            for (int i = 0; i < data.Count; i++)
            {
                collection.Add(data[i]);
            }
            APIGridView.ItemsSource = collection;
        }
    }
}
