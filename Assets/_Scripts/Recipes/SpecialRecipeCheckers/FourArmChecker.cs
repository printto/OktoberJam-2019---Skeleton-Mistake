using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourArmChecker
{
    
    public static bool Check(List<IngredientBase> ingredients)
    {
        if(ingredients.Count != 4)
        {
            return false;
        }
        int headCount = 0;
        int bodyCount = 0;
        int armCount = 0;
        for (int i = 0; i < ingredients.Count; i++)
        {
            if (ingredients[i].ingredientType == IngredientType.headIngredient)
            {
                headCount++;
            }
            else if (ingredients[i].ingredientType == IngredientType.bodyIngredient)
            {
                bodyCount++;
            }
            else if (ingredients[i].ingredientType == IngredientType.armIngredient)
            {
                armCount++;
            }
        }
        return (headCount == 1 && bodyCount == 1 && armCount == 2);
    }

}
