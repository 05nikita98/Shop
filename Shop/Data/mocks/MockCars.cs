using Shop.Data.interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {

            get
            {
                return new List<Car>()
                {

                    new Car() {

                        name = "Tesla",
                        shortDesc = "Быстрый, экологичный",
                        longDesc = "Красивый, спортивный, тихий автомобиль для будущего",
                        img = "/img/Tesla.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car()
                    {
                        name = " Woltvagen Polo",
                        shortDesc = "Надёжный, не дорогой ",
                        longDesc = "Привлекательный, комфортный ",
                        img = "/img/polo.jpg",
                        price = 16000,
                        isFavorite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car()
                    {
                        name = " BMW M8",
                        shortDesc = "Максимальная динамика движения и эксклюзивность ",
                        longDesc = "Доставит Вам максимальное удовольствие от вождения в атмосфере спортивного стиля и роскоши как на дорогах, так и на гоночной трассе ",
                        img = "/img/BMW.jpg",
                        price = 41000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car()
                    {
                        name = "Mercedes Benz S класс",
                        shortDesc = "Уникальный комфорт и технологии безопасности ",
                        longDesc = "Характерный образ, яркие впечатления и полный контроль ",
                        img = "/img/mercedes.jpg",
                        price = 44000,
                        isFavorite = true,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car()
                    {
                        name = "Maserati Levante",
                        shortDesc = "Мощный, элегантный автомобиль ",
                        longDesc = "Способный доставить Вас куда угодно ",
                        img = "/img/maserati.jpg",
                        price = 43000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car()
                    {
                        name = "Kia K5",
                        shortDesc = "Впечатляет притязательных",
                        longDesc = "Эффективный и мощный ",
                        img = "/img/Kia.jpg",
                        price = 33000,
                        isFavorite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }               
        public IEnumerable<Car> getFavCars { get ; set ; }

        public Car getObjectCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}
