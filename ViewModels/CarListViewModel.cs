using ASP.NET1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET1.VewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> AllCars { get; set; }
        public string _currCategory { get; set; }
    }
}
