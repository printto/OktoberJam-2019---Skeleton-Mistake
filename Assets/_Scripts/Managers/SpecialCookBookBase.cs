using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cookbook", menuName = "Cookbook/Special Cookbook")]
public class SpecialCookBookBase : CookBookBase
{

    public RecipeBase spiderRecipe;
    public RecipeBase weirdSpiderRecipe;

    public RecipeBase wendigoConstantRecipe;
    public RecipeBase wendigoRecipe;

    public RecipeBase fourArmRecipe;

    public RecipeBase checkSpecialRecipe(List<IngredientBase> ingredients)
    {
        if (Utility.ListAContainsListB<IngredientBase>(spiderRecipe.recipeCode, ingredients))
        {
            return weirdSpiderRecipe;
        }
        else if (WendigoChecker.Check(wendigoConstantRecipe.recipeCode, ingredients))
        {
            return wendigoRecipe;
        }
        return defaultRecipe;
    }

}
