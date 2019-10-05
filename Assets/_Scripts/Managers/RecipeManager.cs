using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeManager : MonoBehaviour
{

    public CookBookBase cookbook;

    public RecipeBase generateResult()
    {
        foreach (RecipeBase recipe in cookbook.GetRecipes())
        {
            if(Utility.CompareLists<IngredientBase>(recipe.recipeCode, IngredientManager.Instance.ingredientList))
            {
                return recipe;
            }
        }
        return cookbook.defaultRecipe;
    }

}
