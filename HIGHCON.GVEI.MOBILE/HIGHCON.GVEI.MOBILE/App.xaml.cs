using HIGHCON.GVEI.MOBILE.Controls;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HIGHCON.GVEI.MOBILE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPageGradientHeader(new MainPage())
            {
                LeftColor = Color.FromHex("#109F8D"),
                RightColor = Color.FromHex("#36ED81")
            };

            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
