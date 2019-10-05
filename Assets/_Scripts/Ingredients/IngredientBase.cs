using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Ingredient")]
public class IngredientBase : ScriptableObject
{

    [Header("Ingredient variables")]
    GameObject ingredientSprite;
    string ingredientName;
    string description;

}
