using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "Recipe")]
public class RecipeBase : ScriptableObject
{

    [Header("Recipe variables")]
    public Sprite successSprite;
    public IngredientBase[] recipeCode;
    public string creatureName;
    public string description;

}
