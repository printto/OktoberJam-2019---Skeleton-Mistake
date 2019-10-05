using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RemoveButton : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {
        IngredientManager.Instance.ingredientList.RemoveAt(IngredientManager.Instance.ingredientList.Count - 1);
    }

}
