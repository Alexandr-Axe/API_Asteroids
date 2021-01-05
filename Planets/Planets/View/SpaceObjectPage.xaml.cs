using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planets.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Planets.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class PageViewModel : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string _CurrentName;

        public string CurrentName
        {
            get { return _CurrentName; }
            set 
            {
                _CurrentName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentName"));
            }
        }
        private string _Material;

        public string Material
        {
            get { return _Material; }
            set 
            {
                _Material = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Material"));
            }
        }
        private double _Size;

        public double Size
        {
            get { return _Size; }
            set 
            {
                _Size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }
        public SpaceObject ToSpaceObject() 
        {
            SpaceObject SO = new SpaceObject { CurrentName = this.CurrentName, Material = this.Material, Size = this.Size };
            return SO;
        }
        public PageViewModel(SpaceObject SO) 
        {
            CurrentName = SO.CurrentName;
            Material = SO.Material;
            Size = SO.Size;
        }

    }
    public partial class SpaceObjectPage : ContentPage
    {
        ObservableCollection<SpaceObject> sCollection;
        public SpaceObjectPage()
        {
            InitializeComponent();
        }
        public SpaceObjectPage(SpaceObject so, ObservableCollection<SpaceObject> collection) 
        {
            InitializeComponent();
            PageViewModel PVM = new PageViewModel(so);
            BindingContext = PVM;
            sCollection = collection;
        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
            sCollection.Add((BindingContext as PageViewModel).ToSpaceObject());
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}