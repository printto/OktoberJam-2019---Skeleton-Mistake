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

    public RecipeBase HeadWingsConstantRecipe;
    public RecipeBase HeadWingsRecipe;

    public RecipeBase TwinRecipe;

    public RecipeBase HayHeadRecipe;

    public RecipeBase ArmAliveRecipe;

    public RecipeBase checkSpecialRecipe(List<IngredientBase> ingredients)
    {
        if (WeirdSpiderChecker.Check(ingredients, spiderRecipe.recipeCode))
        {
            return weirdSpiderRecipe;
        }
        else if (WendigoChecker.Check(ingredients, wendigoConstantRecipe.recipeCode))
        {
            return wendigoRecipe;
        }
        else if (FourArmChecker.Check(ingredients))
        {
            return fourArmRecipe;
        }
        else if (HeadWingsChecker.Check(ingredients, HeadWingsConstantRecipe.recipeCode))
        {
            return HeadWingsRecipe;
        }
        else if (TwinCheck.Check(ingredients))
        {
            return TwinRecipe;
        }
        else if (HayHeadChecker.Check(ingredients))
        {
            return HayHeadRecipe;
        }
        else if (ArmAliveChecker.Check(ingredients))
        {
            return ArmAliveRecipe;
        }
        return defaultRecipe;
    }

}
