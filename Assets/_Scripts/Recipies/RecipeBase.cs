using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "Recipe")]
public class RecipeBase : ScriptableObject
{

    [Header("Recipe variables")]
    GameObject successSprite;
    IngredientBase[] recipeCode;
    string creatureName;
    string description;

}
