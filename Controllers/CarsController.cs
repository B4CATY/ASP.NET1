using ASP.NET1.Data.Interfaces;
using ASP.NET1.VewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET1.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        public CarsController(IAllCars allCars, ICarsCategory allCategories)
        {
            _allCars = allCars;
            _allCategories = allCategories;
        }
        public ViewResult List_View()
        {
            ViewBag.Title = "Page with autos";
            CarListViewModel carList = new CarListViewModel();
            carList.AllCars = _allCars.Cars;
            carList._currCategory = "Autos";
            return View(carList); 
        }
    }
}
