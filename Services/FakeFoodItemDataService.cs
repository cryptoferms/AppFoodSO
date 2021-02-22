using System;
using System.Collections.ObjectModel;
using DemoApp.Model;
using System.Linq;

namespace DemoApp.Services
{
    public class FakeFoodItemDataService
    {
        public ObservableCollection<FoodItem> FoodItems { get; set; }

        public FakeFoodItemDataService()
        {
            FoodItems = new ObservableCollection<FoodItem>
            {
                new FoodItem
                {
                    ProductID = 1,
                    CategoryID = 1,
                    ImageUrl = "MainBurger",
                    Name = "Burger and Pizza Hub 1",
                    Description = "Burger - Pizza - Breakfast",
                    Rating = " 4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart"
                },
                new FoodItem
                {
                    ProductID = 2,
                    CategoryID = 1,
                    ImageUrl = "MainBurger",
                    Name = "Burger and Pizza Hub 2",
                    Description = "Burger - Pizza - Breakfast",
                    Rating = " 4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "EmptyHeart"
                },
                new FoodItem
                {
                    ProductID = 3,
                    CategoryID = 1,
                    ImageUrl = "MainBurger",
                    Name = "Burger and Pizza Hub 3",
                    Description = "Burger - Pizza - Breakfast",
                    Rating = " 4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart"
                },
                new FoodItem
                {
                    ProductID = 4,
                    CategoryID = 1,
                    ImageUrl = "MainBurger",
                    Name = "Burger and Pizza Hub 4",
                    Description = "Burger - Pizza - Breakfast",
                    Rating = " 4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "EmptyHeart"
                },
                new FoodItem
                {
                    ProductID = 5,
                    CategoryID = 2,
                    ImageUrl = "MainPizza",
                    Name = "Pizza",
                    Description = "Pizza - Breakfast",
                    Rating = " 4.4",
                    RatingDetail = " (120 raitings)",
                    HomeSelected = "CompleteHeart"
                },
                new FoodItem
                {
                    ProductID = 6,
                    CategoryID = 2,
                    ImageUrl = "MainPizza",
                    Name = "Pizza Hub 2",
                    Description = "Pizza Hub 2- Breakfast",
                    Rating = " 4.8",
                    RatingDetail = " (156 raitings)",
                    HomeSelected = "EmptyHeart"
                },
                new FoodItem
                {
                    ProductID = 7,
                    CategoryID = 3,
                    ImageUrl = "MainDessert",
                    Name = "Ice Creams",
                    Description = "Icecream - Breakfast",
                    Rating = " 4.4",
                    RatingDetail = " (120 raitings)",
                    HomeSelected = "CompleteHeart"
                },
                new FoodItem
                {
                    ProductID = 8,
                    CategoryID = 3,
                    ImageUrl = "MainDessert",
                    Name = "Cakes",
                    Description = "Cool Cakes- Breakfast",
                    Rating = " 4.8",
                    RatingDetail = " (156 raitings)",
                    HomeSelected = "EmptyHeart"
                }
             };
        }

        public ObservableCollection<FoodItem> GetFoodItems()
        {
            return FoodItems;
        }

        public ObservableCollection<FoodItem> GetFoodItemsByCategory(int categoryID)
        {
            var foodItemsByCategory = new ObservableCollection<FoodItem>();
            var items = FoodItems.Where(f => f.CategoryID == categoryID).ToList();
            foreach (var item in items)
            {
                foodItemsByCategory.Add(item);
            }
            return foodItemsByCategory;
        }
    }
}
