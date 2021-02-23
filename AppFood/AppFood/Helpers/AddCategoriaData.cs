using AppFood.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFood.Helpers
{
    public class AddCategoriaData
    {
        public List<Categoria> Categorias { get; set; }
        public AddCategoriaData()
        {
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
    }
}
