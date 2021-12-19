using ASP.NET1.Data.Interfaces;
using ASP.NET1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET1.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ categotyName = "ElectroCar", desc = "Modern type of transport"},
                    new Category{ categotyName = "ClassicCar", desc = "Machines with a combustion engine"}
                };
            }

        }

    }
}
