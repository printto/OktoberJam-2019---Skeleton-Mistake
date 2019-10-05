using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IngredientObject : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{

    public IngredientBase ingredientScript;
    private Vector3 currentObjectPosition;
    public void OnDrag(PointerEventData eventData)
    {
        Managers.Instance.m_UIManager.SelectedItemHandleMouseDrag(eventData);

    }


    public void OnPointerDown(PointerEventData eventData)
    {
        Sprite currentImage = this.GetComponent<Image>().sprite;
        Debug.Log("sd");
        float OFFSET = 50f;
        currentObjectPosition = this.transform.position;
        currentObjectPosition.x = currentObjectPosition.x + OFFSET;
        currentObjectPosition.z = currentObjectPosition.z - OFFSET;
        Managers.Instance.m_UIManager.OnDragItem.gameObject.SetActive(!Managers.Instance.m_UIManager.OnDragItem.gameObject.activeSelf);

        Managers.Instance.m_UIManager.OnDragItem.position = currentObjectPosition;
        Managers.Instance.m_UIManager.OnDragItem.GetComponent<Image>().sprite = currentImage;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Managers.Instance.m_UIManager.SelectedItemHandleMouseDrop(eventData, ingredientScript);
    }

    void Start()
    {
        gameObject.GetComponent<Image>().sprite = ingredientScript.ingredientSprite;
    }




}
