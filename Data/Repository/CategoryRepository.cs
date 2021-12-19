using ASP.NET1.Data.Interfaces;
using ASP.NET1.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET1.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent _appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => _appDBContent.Category;
    }
}
