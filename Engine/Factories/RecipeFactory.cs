using System.Collections.Generic;
using System.Linq;
using Engine.Models;
namespace Engine.Factories
{
    public static class RecipeFactory
    {
        private static readonly List<Recipe> _recipes = new List<Recipe>();
        static RecipeFactory()
        {
            Recipe HealPotion = new Recipe(1, "Healing Potion");
            HealPotion.AddIngredient(302, 1);
            HealPotion.AddIngredient(300, 1);
            _recipes.Add(HealPotion);
        }
        public static Recipe RecipeByID(int id)
        {
            return _recipes.FirstOrDefault(x => x.ID == id);
        }
    }
}
