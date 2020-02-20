using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;
using HIGHCON.GVEI.MOBILE.Interfaces;
using HIGHCON.GVEI.MOBILE.Models;

namespace HIGHCON.GVEI.MOBILE.Services
{
   public class ApiService : IApi
    {
        private static ApiService _instance;
        public static ApiService Instance = _instance ?? (_instance = new ApiService());
        private readonly IApi _api;

        private ApiService()
        {
            _api = RestService.For<IApi>("https://apigvei.getsandbox.com");
                
                //("https://yellow.getsandbox.com");
        }

        public async Task<IList<User>> GetUser()
        {
            return await _api.GetUser();
        }

        public async Task<IList<Car>> GetCar()
        {
            return await _api.GetCar();
        }
    }
}
