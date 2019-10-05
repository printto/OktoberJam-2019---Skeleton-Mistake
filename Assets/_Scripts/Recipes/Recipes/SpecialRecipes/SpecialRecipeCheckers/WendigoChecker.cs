using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WendigoChecker
{

    public static bool Check(List<IngredientBase> ingredients, List<IngredientBase> WendigoRecipe)
    {

        if (ingredients.Count != 5)
        {
            return false;
        }

        foreach (IngredientBase ingredient in WendigoRecipe)
        {
            if (!ingredients.Contains(ingredient))
            {
                return false;
            }
        }

        // if there are remaining elements in the lookUp, continue
        int legCount = 0;
        int tailCount = 0;
        for (int i = 0; i < ingredients.Count; i++)
        {
            if(ingredients[i].ingredientType == IngredientType.legIngredient)
            {
                legCount++;
            }
            else if (ingredients[i].ingredientType == IngredientType.tailIngredient)
            {
                tailCount++;
            }
        }
        return (legCount == 1 && tailCount == 1);
    }

}
