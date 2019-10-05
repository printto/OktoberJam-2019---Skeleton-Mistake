using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager
{
    public Transform PanelTransform;
    public Button[] BoneSelectionButtons;
    public Transform SelectedItem;

    public UIManager()
    {

    }

    public void Start(GameObject parentCanvas)
    {
        PanelTransform = parentCanvas.transform.Find("Canvas/Panel");
        InitButton();
    }

    public void Update()
    {

    }



    private void InitButton()
    {
        BoneSelectionButtons = PanelTransform.GetComponentsInChildren<Button>();

        foreach (Button button in BoneSelectionButtons)
        {
            button.onClick.AddListener(() => OnClickBoneSelectionButton(button));
        }
    }


    private void OnClickBoneSelectionButton(Button button)
    {
        Debug.Log(button.name);
        PanelTransform
    }
}
