using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using HIGHCON.GVEI.MOBILE.Interfaces;
using HIGHCON.GVEI.MOBILE.Models;
using HIGHCON.GVEI.MOBILE.Views;

namespace HIGHCON.GVEI.MOBILE.ViewModels
{
   public class UserViewModel : BaseViewModel, IAsyncInitialization
    {
        public Task Initialization { get; }

        private readonly IApi _api;
        private readonly INavigation _navigation;

        public ObservableCollection<User> Users { get; private set; }

        public Command<User> GoToDetailsCommand { get; private set; }

        public UserViewModel(INavigation navigation, IApi api)
        {
            _navigation = navigation;
            _api = api;

            Users = new ObservableCollection<User>();

            GoToDetailsCommand = new Command<User>(
                async (user) => await GoToDetailsAsync(user)
            );

            Initialization = InitializationAsync();
        }

        private async Task InitializationAsync()
        {
            await LoadTripsAsync();
        }

        private async Task LoadTripsAsync()
        {
            try
            {
                var _users = await _api.GetUser();

                foreach (var user in _users)
                    Users.Add(user);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
        }

        private async Task GoToDetailsAsync(User user)
        {
            await _navigation.PushAsync(new ConsultPage());
        }
    }
}
