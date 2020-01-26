using HIGHCON.GVEI.MOBILE.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HIGHCON.GVEI.MOBILE
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
   // [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PopupNavigation.PushAsync(new PopUp());
        }
 
        private void OpenPopup(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new PopUp());
        }

        private void ClickedOk(object sender, EventArgs e)
        {
          
            //NavigationPage nav = new NavigationPage(new CarPage());
            Navigation.PushAsync(new HomePage());
        }
    }
}
