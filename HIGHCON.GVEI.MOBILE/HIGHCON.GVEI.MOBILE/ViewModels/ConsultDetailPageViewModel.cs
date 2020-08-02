using System;
using System.Collections.Generic;
using System.Text;
using HIGHCON.GVEI.MOBILE.Models;

namespace HIGHCON.GVEI.MOBILE.ViewModels
{
   public class ConsultDetailPageViewModel : BaseViewModel
    {
        private Car _car;
        public Car Car
        {
            get => _car;
            set => RaiseIfPropertyChanged(ref _car, value);
        }

        public ConsultDetailPageViewModel(Car car)
        {
            _car = car;
        }

    }
}
