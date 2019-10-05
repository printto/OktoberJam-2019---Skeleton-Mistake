using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "Recipe")]
public class RecipeBase : ScriptableObject
{

    [Header("Recipe variables")]
    public GameObject successSprite;
    public IngredientBase[] recipeCode;
    public string creatureName;
    public string description;

    public string getCode()
    {
        string temp = "";
        foreach(IngredientBase ingre in recipeCode)
        {
            temp += ingre.ingredientName;
        }
        return temp;
    }

}
