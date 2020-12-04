using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColorVRWebSite.Data.Interfaces;
using ColorVRWebSite.Data.Models;

namespace ColorVRWebSite.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "Physics", Description = "Everything Related to Physics" },
                         new Category { CategoryName = "Chemestry", Description = "Everything Related to Chemestry" }
                     };
            }
        }
    }
}
