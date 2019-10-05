using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmAliveChecker
{
    public static bool Check(List<IngredientBase> ingredients)
    {
        int armCount = 0;
        int legCount = 0;
        for (int i = 0; i < ingredients.Count; i++)
        {
            if (ingredients[i].ingredientType == IngredientType.armIngredient)
            {
                armCount++;
            }
            else if (ingredients[i].ingredientType == IngredientType.legIngredient)
            {
                legCount++;
            }
        }
        return (armCount + legCount >= 3 && armCount + legCount == ingredients.Count);
    }
}
