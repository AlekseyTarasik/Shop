using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category>
                {
                    new Category { categoryName= "электромобили", desc = "современный вид транпорта"},
                    new Category { categoryName = "стандартные автомобили", desc = "автомобили с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
