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
    public class AddCategoriaData
    {
        public List<Categoria> Categorias { get; set; }
        FirebaseClient client;
        public AddCategoriaData()
        {
            client = new FirebaseClient("https://foodapp-d03c7-default-rtdb.firebaseio.com/");
            Categorias = new List<Categoria>()
            {
                new Categoria()
                {
                    CategoriaID= 1,
                    CategoriaName= "Hamburguer",
                    CategoriaPoster= "MainBurger.png",
                    ImageUrl= "Burger.png"
                },
                new Categoria()
                {
                    CategoriaID= 2,
                    CategoriaName= "Pizza",
                    CategoriaPoster= "MainPizza.png",
                    ImageUrl= "Pizza.png"
                },
                new Categoria()
                {
                    CategoriaID= 3,
                    CategoriaName= "Desserts",
                    CategoriaPoster= "MainDessert.png",
                    ImageUrl= "Dessert.png"
                },
                new Categoria()
                {
                    CategoriaID= 4,
                    CategoriaName= "Hamburguer Vegano",
                    CategoriaPoster= "MainBurger.png",
                    ImageUrl= "Burger.png"
                },
                new Categoria()
                {
                    CategoriaID= 5,
                    CategoriaName= "Pizza Vegana",
                    CategoriaPoster= "MainBurger.png",
                    ImageUrl= "Pizza.png"
                },
            };
        }
        public async Task AddCategoriaAsync()
        {
            try
            {
                foreach (var category in Categorias)
                {
                    await client.Child("Categorias").PostAsync(new Categoria()
                    {
                        CategoriaID = category.CategoriaID,
                        CategoriaName = category.CategoriaName,
                        CategoriaPoster = category.CategoriaPoster,
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
