using HIGHCON.GVEI.MOBILE.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIGHCON.GVEI.MOBILE.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HIGHCON.GVEI.MOBILE.Services;
using HIGHCON.GVEI.MOBILE.Models;
using Plugin.Connectivity;

namespace HIGHCON.GVEI.MOBILE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUp 
    {

        private readonly INavigation _navigation;
       // private readonly IApi _api;

       // private Account _account;

        public PopUp()
        {
            InitializeComponent();         
        }       

        public void Handle_Clicked(object sender, System.EventArgs e)
        {

            status.Text = CrossConnectivity.Current.IsConnected ? null : "Sem acesso a internet!";

            if (status.Text != null) 
            {
                return;
            }

            var _user = ServiceWS.GetUser(user.Text, senha.Text); 

            if (_user != null)
            {
                PopupNavigation.Instance.PopAsync();
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                status.Text = "Usuario ou senha invalido!";
            }
        }
    }
}