using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeirdSpiderChecker
{

    public static bool Check(List<IngredientBase> ingredients, List<IngredientBase> SpiderRecipe)
    {

        foreach (IngredientBase ingredient in SpiderRecipe)
        {
            if (!ingredients.Contains(ingredient))
            {
                return false;
            }
        }

        return true;
    }

}
