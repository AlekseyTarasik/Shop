using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla Model S", 
                        shortDesc = "быстрая америка", 
                        longDesc = "Лучшее предложение от американского рынка", 
                        img = "https://tesla-cars.by/wp-content/webpc-passthru.php?src=https://tesla-cars.by/wp-content/uploads/2022/02/Tesla-Model-S-2021_2.jpg&nocache=1", 
                        price = 45000, 
                        isFavorite = true, 
                        available = true, 
                        Category =  _categoryCars.AllCategories.First() 
                    },
                    new Car {
                        name = "BMW M5 F90",
                        shortDesc = "дерзкий немец",
                        longDesc = "Лучший подключаемый полный привод",
                        img = "https://autozal.com/uploads/posts/2020-11/1604248234_2020-bmw-m5-f90-lci-competition-restajling-foto-27.jpg",
                        price = 21000,
                        isFavorite = true,
                        available = true,
                        Category =  _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Mercedes S222",
                        shortDesc = "спокойный винтаж",
                        longDesc = "Лучшая колыбель бля бизнесменов и бизнесвуменов",
                        img = "https://upload.wikimedia.org/wikipedia/commons/2/2b/2019_Mercedes-Benz_S350d_L_AMG_Line_Executive_3.0_Front.jpg",
                        price = 65500,
                        isFavorite = true,
                        available = true,
                        Category =  _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Audi e-Trone",
                        shortDesc = "электрическая зажигалка",
                        longDesc = "Красивая и заряженная табуретка 2021 года",
                        img = "https://wroom.ru/i/cars2/audi_etron_1.jpg",
                        price = 49000,
                        isFavorite = true,
                        available = true,
                        Category =  _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Volkswagen Jetta",
                        shortDesc = "уютный бюджетник",
                        longDesc = "Спокойный бюджетник для тех, кому не по корману остальные варианты",
                        img = "https://s.auto.drom.ru/i24245/c/photos/fullsize/volkswagen/jetta/volkswagen_jetta_954959.jpg",
                        price = 13000,
                        isFavorite = true,
                        available = true,
                        Category =  _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
