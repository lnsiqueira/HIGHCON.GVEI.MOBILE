using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HIGHCON.GVEI.MOBILE.Interfaces;
using HIGHCON.GVEI.MOBILE.Models;
using HIGHCON.GVEI.MOBILE.Views;
using HIGHCON.GVEI.MOBILE.Views.NewCar;
using Xamarin.Forms;

namespace HIGHCON.GVEI.MOBILE.ViewModels
{
   public class NewCarPageViewmodel : BaseViewModel, IAsyncInitialization
    {
        public Task Initialization { get; }

       
        private readonly INavigation _navigation;

        public ObservableCollection<CarDetail> Car { get; private set; }

        public Command<CarDetail> GoToDetailsCommand { get; private set; }

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
        public NewCarPageViewmodel(INavigation navigation )
        {
            _navigation = navigation;
         

            Car = new ObservableCollection<CarDetail>();

            GoToDetailsCommand = new Command<CarDetail>(
                async (CarDetail) => await GoToDetailsAsync(CarDetail)
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
               // var cars = await _api.GetCarDetail();

                //foreach (var car in cars)
                   // Car.Add(car);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
        }
            private async Task GoToDetailsAsync(CarDetail carDetail)
            {
                await _navigation.PushAsync(new NewCarDetailPage(carDetail));
            
        }
    }
}
