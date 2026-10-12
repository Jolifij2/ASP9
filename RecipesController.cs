using BootstrapApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BootstrapApp.Controllers
{
    public class RecipesController : Controller
    {
        private static List<Recipe> _recipes = new List<Recipe>
        {
            new Recipe
            {
                Id = 1,
                Name = "Борщ",
                Cuisine = "Русская",
                CookingTime = 120,
                Difficulty = 4,
                Description = "Традиционный свекольный суп с мясом и овощами."
            },
            new Recipe
            {
                Id = 2,
                Name = "Паста Карбонара",
                Cuisine = "Итальянская",
                CookingTime = 30,
                Difficulty = 2,
                Description = "Спагетти с беконом, яйцом и сыром пармезан."
            },
            new Recipe
            {
                Id = 3,
                Name = "Суши Филадельфия",
                Cuisine = "Японская",
                CookingTime = 60,
                Difficulty = 5,
                Description = "Роллы с лососем, сливочным сыром и огурцом."
            },
            new Recipe
            {
                Id = 4,
                Name = "Пельмени",
                Cuisine = "Русская",
                CookingTime = 90,
                Difficulty = 3,
                Description = "Тесто с мясной начинкой, отварные или жареные."
            },
            new Recipe
            {
                Id = 5,
                Name = "Тирамису",
                Cuisine = "Итальянская",
                CookingTime = 45,
                Difficulty = 3,
                Description = "Десерт из печенья савоярди, кофе и маскарпоне."
            }
        };

        public IActionResult Index()
        {
            return View(_recipes);
        }
    }
}
