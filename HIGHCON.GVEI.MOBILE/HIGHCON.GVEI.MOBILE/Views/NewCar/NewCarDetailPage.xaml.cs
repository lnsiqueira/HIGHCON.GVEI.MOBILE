using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HIGHCON.GVEI.MOBILE.Models;
using HIGHCON.GVEI.MOBILE.ViewModels;
using HIGHCON.GVEI.MOBILE.Controls;
using HIGHCON.GVEI.MOBILE.Services;

namespace HIGHCON.GVEI.MOBILE.Views.NewCar
{
    public partial class NewCarDetailPage : ContentPage
    {
        public NewCarDetailPage(CarDetail carDetail)
        {
            InitializeComponent();
            BindingContext = new NewCarPageViewmodel(Navigation);
        }
        private async void OnGoBackClick(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}