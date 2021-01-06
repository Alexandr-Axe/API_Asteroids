using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Planets.Models;

namespace Planets.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpaceObjectsPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public SpaceObjectsPage()
        {
            InitializeComponent();
            SpaceObjects Objects = new SpaceObjects();
            BindingContext = Objects;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;

            Page p = new SpaceObjectPage((((ListView)sender).SelectedItem) as SpaceObject, (BindingContext as SpaceObjects).AllObjects);
            await Application.Current.MainPage.Navigation.PushAsync(p);
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
        

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
