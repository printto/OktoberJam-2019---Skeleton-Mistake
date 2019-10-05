using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IngredientPressButton : MonoBehaviour, IPointerClickHandler
{
    public IngredientBase ingredientScript;

    public void OnPointerClick(PointerEventData eventData)
    {
        IngredientManager.Instance.ingredientList.Add(ingredientScript);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Image>().sprite = ingredientScript.ingredientSprite;
    }
}
