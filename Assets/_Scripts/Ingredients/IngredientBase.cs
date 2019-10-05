using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum IngredientType
{
    generalIngredient,
    headIngredient,
    bodyIngredient,
    armIngredient,
    legIngredient,
    tailIngredient,
    extraIngredient/*,
    specialSpecificIngredients,
    specialAllHeadIngredients,
    specialAllBodyIngredients,
    specialAllArmIngredients,
    specialAllLegIngredients,
    specialAllTailIngredients,
    specialAllExtraIngredients,
    */
}

[CreateAssetMenu(fileName = "Ingredient", menuName = "Ingredient/Normal Ingredient")]
public class IngredientBase : ScriptableObject
{

    [Header("Ingredient variables")]
    public Sprite ingredientSprite;
    public string ingredientName;
    public string description;
    public IngredientType ingredientType;

}
