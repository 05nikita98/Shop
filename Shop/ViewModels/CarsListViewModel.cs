using Shop.Data.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace Shop.ViewModels
{
    public class CarsListViewModel
    { 
        public IEnumerable<Car> allCars { get; set; }
        public string currCategory { get; set; }
    }
}
