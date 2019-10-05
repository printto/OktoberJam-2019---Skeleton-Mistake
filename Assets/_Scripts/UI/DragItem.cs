using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragItem : MonoBehaviour
{
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        OnPointerDown(eventData);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!eventData.dragging)
        {
            Debug.Log("sad");
        }
    }

}
