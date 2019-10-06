using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadWingsChecker
{

    public static bool Check(List<IngredientBase> ingredients, List<IngredientBase> HeadWingsRecipe)
    {
        
        if (ingredients.Count != 2)
        {
            return false;
        }

        foreach (IngredientBase ingredient in HeadWingsRecipe)
        {
            if (!ingredients.Contains(ingredient))
            {
                return false;
            }
        }

        // if there are remaining elements in the lookUp, continue
        int headCount = 0;
        for (int i = 0; i < ingredients.Count; i++)
        {
            if (ingredients[i].ingredientType == IngredientType.headIngredient)
            {
                headCount++;
            }
        }
        return (headCount == 1);
    }
}
