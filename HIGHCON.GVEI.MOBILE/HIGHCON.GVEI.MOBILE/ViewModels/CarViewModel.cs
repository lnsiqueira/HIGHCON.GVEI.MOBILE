using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HIGHCON.GVEI.MOBILE.Interfaces;
using HIGHCON.GVEI.MOBILE.Models;
using HIGHCON.GVEI.MOBILE.Views;
using System.Collections.ObjectModel;

namespace HIGHCON.GVEI.MOBILE.ViewModels
{
    public class CarViewModel : BaseViewModel, IAsyncInitialization
    {
        public Task Initialization { get; }

       
        private readonly INavigation _navigation;

        public ObservableCollection<Car> Cars { get; private set; }

        public Command<Car> GoToDetailsCommand { get; private set; }

        public CarViewModel(INavigation navigation )
        {
            _navigation = navigation;
             

            Cars = new ObservableCollection<Car>();

            //GoToDetailsCommand = new Command<Car>(
            //    async (car) => await GoToDetailsAsync(car)
            //);

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
               // var cars = await _api.GetCar();

               // foreach (var car in cars)
               //     Cars.Add(car);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
        }

        //private async Task GoToDetailsAsync(Car car)
        //{
        //    await _navigation.PushAsync(new CarDetailView(car));
        //}
    }
}
