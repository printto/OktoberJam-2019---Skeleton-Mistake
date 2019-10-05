using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WendigoChecker
{

    public static bool Check(List<IngredientBase> WendigoRecipe, List<IngredientBase> ingredients)
    {
        if (WendigoRecipe == null || ingredients == null || WendigoRecipe.Count != ingredients.Count)
            return false;
        if (WendigoRecipe.Count == 0)
            return true;
        Dictionary<IngredientBase, int> lookUp = new Dictionary<IngredientBase, int>();
        // create index for the first list
        for (int i = 0; i < WendigoRecipe.Count; i++)
        {
            int count = 0;
            if (!lookUp.TryGetValue(WendigoRecipe[i], out count))
            {
                lookUp.Add(WendigoRecipe[i], 1);
                continue;
            }
            lookUp[WendigoRecipe[i]] = count + 1;
        }
        for (int i = 0; i < ingredients.Count; i++)
        {
            int count = 0;
            if (!lookUp.TryGetValue(ingredients[i], out count))
            {
                // early exit as the current value in B doesn't exist in the lookUp (and not in ListA)
                return false;
            }
            count--;
            if (count <= 0)
                lookUp.Remove(ingredients[i]);
            else
                lookUp[ingredients[i]] = count;
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
