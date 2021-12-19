using ASP.NET1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET1.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;  }
        IEnumerable<Car> getFavCars { get; }
        Car getObjectCar(int carID);

    }
}
