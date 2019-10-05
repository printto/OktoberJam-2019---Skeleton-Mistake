using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Ingredient")]
public class IngredientBase : ScriptableObject
{

    [Header("Ingredient variables")]
    public Sprite ingredientSprite;
    public string ingredientName;
    public string description;

}
