using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientBar : MonoBehaviour
{

    List<IngredientBase> ingredientList;

    public GameObject[] ingredientBoxes;

    public Sprite defaultSprite;

    private void Start()
    {
        ingredientList = new List<IngredientBase>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ingredientList.Count < IngredientManager.Instance.ingredientList.Count)
        {
            ingredientBoxes[ingredientList.Count].GetComponent<Image>().sprite = IngredientManager.Instance.ingredientList[ingredientList.Count].ingredientSprite;
            ingredientList.Add(IngredientManager.Instance.ingredientList[ingredientList.Count]);
        }
        if (ingredientList.Count > IngredientManager.Instance.ingredientList.Count)
        {
            ingredientBoxes[ingredientList.Count - 1].GetComponent<Image>().sprite = defaultSprite;
            ingredientList.RemoveAt(ingredientList.Count - 1);
        }
    }
}
