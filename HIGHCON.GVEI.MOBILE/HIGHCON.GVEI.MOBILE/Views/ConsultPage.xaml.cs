using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIGHCON.GVEI.MOBILE.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using HIGHCON.GVEI.MOBILE.Services;

namespace HIGHCON.GVEI.MOBILE.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultPage : ContentPage
    {
        //public ConsultPage()
        //{
        //}

        public ConsultPage()
        {
            InitializeComponent();
            BindingContext = new ConsultPageViewsModels(Navigation, ApiService.Instance);

            //listCars.RefreshCommand = new Command(() => {
            //    //Do your stuff.    
            //    RefreshData();
            //    listCars.IsRefreshing = false;
            //});

        }

        public void RefreshData()
        {

        }

        //protected override async void OnAppearing()
        //{
        //    BindingContext = new CarViewModel(Navigation, ApiService.Instance);
        //}

    }
}