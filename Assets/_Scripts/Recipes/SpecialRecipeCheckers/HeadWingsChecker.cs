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

        if (HeadWingsRecipe == null || ingredients == null || HeadWingsRecipe.Count != ingredients.Count)
            return false;
        if (HeadWingsRecipe.Count == 0)
            return true;
        Dictionary<IngredientBase, int> lookUp = new Dictionary<IngredientBase, int>();
        // create index for the first list
        for (int i = 0; i < HeadWingsRecipe.Count; i++)
        {
            int count = 0;
            if (!lookUp.TryGetValue(HeadWingsRecipe[i], out count))
            {
                lookUp.Add(HeadWingsRecipe[i], 1);
                continue;
            }
            lookUp[HeadWingsRecipe[i]] = count + 1;
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
