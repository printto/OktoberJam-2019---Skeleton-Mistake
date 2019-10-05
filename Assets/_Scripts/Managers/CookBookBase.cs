using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cookbook", menuName = "Cookbook/Normal Cookbook")]
public class CookBookBase : ScriptableObject
{

    [SerializeField]
    private RecipeBase[] recipes;

    public RecipeBase defaultRecipe;

    public RecipeBase[] GetRecipes()
    {
        return recipes;
    }

}
