using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HIGHCON.GVEI.MOBILE.Models;
using Refit;


namespace HIGHCON.GVEI.MOBILE.Interfaces
{
    public interface IApi
    {
        [Get("/apiuser")]
        Task<IList<User>> GetUser();

        [Get("/ListCar")]
        Task<IList<Car>> GetCar();

    }
}
