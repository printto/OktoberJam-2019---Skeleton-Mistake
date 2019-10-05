using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager
{
    public Transform PanelTransform;
    public Button[] buttons;
    public Transform OnDragItem { get; set; }
    public Transform Pot { get; set; }

    public UIManager()
    {

    }

    public void Start(GameObject parentCanvas)
    {
        PanelTransform = parentCanvas.transform.Find("Canvas/Panel");
        OnDragItem = PanelTransform.Find("Top/SelectedItem");
        Pot = PanelTransform.Find("Pot");
        InitButton();
    }

    public void Update()
    {

    }

    public void SelectedItemHandleMouseDrag(PointerEventData eventData)
    {
        OnDragItem.position = eventData.position;
    }

    public void SelectedItemHandleMouseDrop(PointerEventData eventdata, IngredientBase item)
    {
        BoxCollider2D potCollider = Pot.GetComponent<BoxCollider2D>();
        BoxCollider2D selectedItemCollider = OnDragItem.GetComponent<BoxCollider2D>();




        if (potCollider.bounds.Intersects(selectedItemCollider.bounds))
        {
            IngredientManager.Instance.ingredientList.Add(item);
            OnDragItem.gameObject.SetActive(!OnDragItem.gameObject.activeSelf);

        }
        else
        {
            OnDragItem.gameObject.SetActive(!OnDragItem.gameObject.activeSelf);
        }
    }



    private void InitButton()
    {
        buttons = PanelTransform.GetComponentsInChildren<Button>();
        Debug.Log("sad");
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => OnClickBoneSelectionButton(button));
        }
    }


    private void OnClickBoneSelectionButton(Button button)
    {
        Debug.Log(button.name);

    }


}
