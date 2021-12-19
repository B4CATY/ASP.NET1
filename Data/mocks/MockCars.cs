using ASP.NET1.Data.Interfaces;
using ASP.NET1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET1.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars {
            

            get 
            {
                return new List<Car> {
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Fast Auto",
                        longDesc = "Beautiful, fast and quite auto",
                        img = "https://telecomdaily.ru/upload/img/news/teaser/6012931a3ed77953922664.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Quite and quite",
                        longDesc = "Comfortable auto for city",
                        img = "https://images.drive.ru/i/0/5edf7d15ec05c4ff2d000004.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Impertinent and stylish",
                        longDesc = "Comfortable auto for city",
                        img = "https://auto.ironhorse.ru/wp-content/uploads/2020/10/m3-g80-front.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Comfortable and large",
                        longDesc = "Comfortable car for municipal life",
                        img = "https://cdnimg.rg.ru/img/content/204/73/77/20C0673_083_d_850.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _carsCategory.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Noiseless and economy",
                        longDesc = "Comfortable car for municipal life",
                        img = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/2018_Nissan_Leaf_Tekna_Front.jpg/1200px-2018_Nissan_Leaf_Tekna_Front.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    }

                }; 
            }
            

        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
