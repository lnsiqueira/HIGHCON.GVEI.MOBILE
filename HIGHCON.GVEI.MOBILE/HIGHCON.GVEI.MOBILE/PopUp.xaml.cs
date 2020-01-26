using HIGHCON.GVEI.MOBILE.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HIGHCON.GVEI.MOBILE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUp 
    {
        public PopUp()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //PopUpNavigation.Instance.PopAsync(true);

            string _user = user.Text;
            string password = senha.Text;

            if (_user != "lucas")
            {
                //"usuario invalido"
                return;
            }


           ; 
            
            if (password != "x")
            {
                //"senha invalida"
                return;
            }





            //Chama tela HomePage

            //new NavigationPage(new CarPage());
            //Navigation.PushAsync(new CarPage());
            PopupNavigation.Instance.PopAsync();

            Navigation.PushAsync(new HomePage());



        }
    }
}