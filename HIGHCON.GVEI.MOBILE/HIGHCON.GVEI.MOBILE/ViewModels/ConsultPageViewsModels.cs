using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HIGHCON.GVEI.MOBILE.Interfaces;
using HIGHCON.GVEI.MOBILE.Models;
using HIGHCON.GVEI.MOBILE.Views;
using Xamarin.Forms;

namespace HIGHCON.GVEI.MOBILE.ViewModels
{
    public class ConsultPageViewsModels : BaseViewModel, IAsyncInitialization
    {
        public Task Initialization { get; }

        private readonly IApi _api;
        private readonly INavigation _navigation;

        public ObservableCollection<Car> Cars { get; private set; }

        public Command<Car> GoToDetailsCommand { get; private set; }

        //Refresh
        private bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        private void OnPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsRefreshing = true;

                    await RefreshData();

                    IsRefreshing = false;
                });
            }
        }

        private async Task RefreshData()
        {
            await LoadCarsAsync();
        }

        public ConsultPageViewsModels(INavigation navigation, IApi api)
        {
            _navigation = navigation;
            _api = api;

            Cars = new ObservableCollection<Car>();

            GoToDetailsCommand = new Command<Car>(
                async (car) => await GoToDetailsAsync(car)
        );
            Initialization = InitializationAsync();
        }
        private async Task InitializationAsync()
        {
            await LoadCarsAsync();
        }
        private async Task LoadCarsAsync()
        {
            try
            {
                var cars = await _api.GetCar();

                foreach (var car in cars)
                    Cars.Add(car);
            }
            catch(Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
        }
        private async Task GoToDetailsAsync(Car car)
        {
            await _navigation.PushAsync(new ConsultPage());
        }                                      
    }


}
