using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RealtimeCookResultImage : MonoBehaviour
{

    List<IngredientBase> ingredientList;
    RecipeManager cookbook;

    private void Start()
    {
        ingredientList = new List<IngredientBase>();
        cookbook = GameObject.Find("CookbookSystem").GetComponent<RecipeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ingredientList.Count != IngredientManager.Instance.ingredientList.Count)
        {
            ingredientList = new List<IngredientBase>(IngredientManager.Instance.ingredientList);
        }
        GetComponent<Image>().sprite = cookbook.generateResult().successSprite;
    }

}
