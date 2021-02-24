using AppFood.Model;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFood.Helpers
{
    public class AddFoodItemData
    {
        FirebaseClient client;
        public List<FoodItem> FoodItems { get; set; }
        public AddFoodItemData()
        {
            client = new FirebaseClient("https://foodapp-d03c7-default-rtdb.firebaseio.com/");
            FoodItems = new List<FoodItem>()
            {
                new FoodItem
                {
                    ProdutoID=1,
                    CategoriaID=1,
                    ImageUrl="MainBurguer",
                    Name="Hamburguer e Pizza HUB 1",
                    Description= "Hamburguer - Pizza - Café da manha",
                    Rating = "4.8",
                    RatingDetail = "(121 classificações)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                new FoodItem
                {
                    ProdutoID=2,
                    CategoriaID=1,
                    ImageUrl="MainBurguer",
                    Name="Hamburguer e Pizza HUB 2",
                    Description= "Hamburguer - Pizza - Café da manha",
                    Rating = "4.8",
                    RatingDetail = "(121 classificações)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                new FoodItem
                {
                    ProdutoID=7,
                    CategoriaID=3,
                    ImageUrl="MainDessert",
                    Name="Sorvetes",
                    Description= "Sorvete - Café da manhã",
                    Rating = "4.8",
                    RatingDetail = "(121 classificações)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                new FoodItem
                {
                    ProdutoID=8,
                    CategoriaID=3,
                    ImageUrl="MainDessert",
                    Name="Bolos",
                    Description= "Cool Cakes - Café da manhã",
                    Rating = "4.8",
                    RatingDetail = "(200 classificações)",
                    HomeSelected = "EmptyHeart",
                    Price = 45
                },
            };
        }
        public async Task AddFoodItemAsync()
        {
            try
            {
                foreach (var item in FoodItems)
                {
                    await client.Child("FoodItems").PostAsync(new FoodItem()
                    {
                        CategoriaID = item.CategoriaID,
                        ProdutoID = item.ProdutoID,
                        Description = item.Description,
                        HomeSelected = item.HomeSelected,
                        ImageUrl = item.ImageUrl,
                        Name= item.Name,
                        Price = item.Price,
                        Rating = item.Rating,
                        RatingDetail = item.RatingDetail,
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}
