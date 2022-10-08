﻿using Shop.Data.interfaces;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category {categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}

                    
                };
            }
        }
    }
}
