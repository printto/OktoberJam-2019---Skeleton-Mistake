using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionMenu : IMenu
{
    public Transform UITransform;
    public Transform BackButtonTransform;
    public CollectionMenu(Transform parentMenu)
    {
        UITransform = parentMenu.Find("Canvas/CollectionMenu");
        InitBackButton();
    }
    public void Show()
    {
        UITransform.gameObject.SetActive(true);
    }

    public void Back()
    {
        UITransform.gameObject.SetActive(false);
    }

    private void InitBackButton()
    {
        BackButtonTransform = UITransform.Find("BackButton");
        Button backButton = BackButtonTransform.GetComponent<Button>();
        backButton.onClick.AddListener(() => Back());
    }


}
