using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager
{
    public Transform PanelTransform;
    public Transform RootCanvas;
    public Button[] buttons;
    public Transform OnDragItem { get; set; }
    public Transform Pot { get; set; }
    
    public IMenu subMenu;

    public UIManager()
    {

    }

    public void Start(GameObject parentCanvas)
    {
        RootCanvas = parentCanvas.transform;
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

    public void SelectedItemHandleMouseDrop(PointerEventData eventdata, IngredientObject selectedItem)
    {
        BoxCollider2D potCollider = Pot.GetComponent<BoxCollider2D>();
        BoxCollider2D selectedItemCollider = OnDragItem.GetComponent<BoxCollider2D>();




        if (potCollider.bounds.Intersects(selectedItemCollider.bounds))
        {
            IngredientManager.Instance.ingredientList.Add(selectedItem.ingredientScript);
            OnDragItem.gameObject.SetActive(!OnDragItem.gameObject.activeSelf);
            Managers.Instance.m_CameraShake.TriggerShake();
            selectedItem.GetComponent<Image>().color = new Color(0, 0, 0);
            selectedItem.enabled = false;
        }
        else
        {
            OnDragItem.gameObject.SetActive(!OnDragItem.gameObject.activeSelf);
        }
    }



    private void InitButton()
    {
        buttons = PanelTransform.GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => OnClickBoneSelectionButton(button));
        }
    }


    private void OnClickBoneSelectionButton(Button button)
    {
        if (button.name.Equals("CollectionButton"))
        {
            subMenu = new CollectionMenu(RootCanvas);
            subMenu.Show();
        }
        else if (button.name.Equals("MixButton"))
        {
            Mix();
        }

    }

    private void Mix()
    {
        PanelTransform.Find("Boom").gameObject.SetActive(true);
    }



}
