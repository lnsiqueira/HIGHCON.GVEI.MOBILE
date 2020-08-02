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

namespace HIGHCON.GVEI.MOBILE.Views.Consult
{
    public partial class ConsultDetailPage : ContentPage
    {
        public ConsultDetailPage(Car car)
        {
            InitializeComponent();
            BindingContext = new ConsultDetailPageViewModel(car);
        }
        private async void OnGoBackClick(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}