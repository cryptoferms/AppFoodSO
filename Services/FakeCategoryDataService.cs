using System;
using System.Collections.ObjectModel;
using DemoApp.Model;

namespace DemoApp.Services
{
    public class FakeCategoryDataService
    {
        public ObservableCollection<Category> GetCategories()
        {
            return new ObservableCollection<Category>()
            {
                new Category()
                {
                    CategoryID = 1,
                    CategoryName = "Burger",
                    CategoryPoster = "MainBurger",
                    ImageUrl = "Burger.png"
                },
                new Category()
                {
                    CategoryID = 2,
                    CategoryName = "Pizza",
                    CategoryPoster = "MainPizza",
                    ImageUrl = "Pizza.png"
                },
                 new Category()
                {
                    CategoryID = 3,
                    CategoryName = "Desserts",
                    CategoryPoster = "MainDessert.png",
                    ImageUrl = "Dessert.png"
                },
                 new Category()
                {
                    CategoryID = 4,
                    CategoryName = "Veg Burger",
                    CategoryPoster = "MainBurger",
                    ImageUrl = "Burger.png"
                },
                new Category()
                {
                    CategoryID = 5,
                    CategoryName = "Veg Pizza",
                    CategoryPoster = "MainPizza.png",
                    ImageUrl = "Pizza.png"
                },
                 new Category()
                {
                    CategoryID = 6,
                    CategoryName = "Cakes",
                    CategoryPoster = "MainDessert.png",
                    ImageUrl = "Dessert.png"
                }
            };
        }
    }
}
