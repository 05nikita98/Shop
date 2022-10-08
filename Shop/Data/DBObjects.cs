using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
            
        {
            
                

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                new Car()
                {

                    name = "Tesla",
                    shortDesc = "Быстрый, экологичный",
                    longDesc = "Красивый, спортивный, тихий автомобиль для будущего",
                    img = @"C:\Users\nikit\source\repos\Shop\Shop\wwwroot\img\Tesla.jpg",
                    price = 45000,
                    isFavorite = true,
                    available = true,
                    Category = Categories["Электромобили"]
                },
                    new Car()
                    {
                        name = " Woltvagen Polo",
                        shortDesc = "Надёжный, не дорогой ",
                        longDesc = "Привлекательный, комфортный ",
                        img = @"C:\Users\nikit\source\repos\Shop\Shop\wwwroot\img\polo.jpg",
                        price = 16000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car()
                    {
                        name = " BMW M8",
                        shortDesc = "Максимальная динамика движения и эксклюзивность ",
                        longDesc = "Доставит Вам максимальное удовольствие от вождения в атмосфере спортивного стиля и роскоши как на дорогах, так и на гоночной трассе ",
                        img = @"~/img/BMW.jpg",
                        price = 41000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car()
                    {
                        name = "Mercedes Benz S класс",
                        shortDesc = "Уникальный комфорт и технологии безопасности ",
                        longDesc = "Характерный образ, яркие впечатления и полный контроль ",
                        img = @"C:\Users\nikit\source\repos\Shop\Shop\wwwroot\img\mercedes.jpg",
                        price = 44000,
                        isFavorite = true,
                        available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car()
                    {
                        name = "Maserati Levante",
                        shortDesc = "Мощный, элегантный автомобиль ",
                        longDesc = "Способный доставить Вас куда угодно ",
                        img = @"C:\Users\nikit\source\repos\Shop\Shop\wwwroot\img\maserati.jpg",
                        price = 43000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car()
                    {
                        name = "Kia K5",
                        shortDesc = "Впечатляет притязательных",
                        longDesc = "Эффективный и мощный ",
                        img = @"C:\Users\nikit\source\repos\Shop\Shop\wwwroot\img\Kia.jpg",
                        price = 33000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    }
                    );
            }
            content.SaveChanges();
        }

       private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get {
                if (category == null) {

                    var List = new Category[] {
                        new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                        new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in List)

                        category.Add(el.categoryName, el);
                }

                return category;
            }

        }
    }

}
