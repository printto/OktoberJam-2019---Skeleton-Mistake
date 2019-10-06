using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayHeadChecker
{
    public static bool Check(List<IngredientBase> ingredients)
    {
        int headCount = 0;
        for (int i = 0; i < ingredients.Count; i++)
        {
            if (ingredients[i].ingredientType == IngredientType.headIngredient)
            {
                headCount++;
            }
        }
        return (headCount >= 2 && headCount == ingredients.Count);
    }
}
