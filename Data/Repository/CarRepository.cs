using ASP.NET1.Data.Interfaces;
using ASP.NET1.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET1.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent _appDBContent;
        public CarRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => _appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => _appDBContent.Car.Where(c => c.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carID) => _appDBContent.Car.FirstOrDefault(c => c.id == carID);
    }
}
