using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultMenu : IMenu
{
    public Transform UITransform;
    public Transform BackButtonTransform;
    public Transform Bar;

    public ResultMenu(Transform parentTransform)
    {
        UITransform = parentTransform.Find("Canvas/ResultMenu");
        Bar = parentTransform.transform.Find("Canvas/Bottom/IngredientBarPlaceHolder");

        InitBackButton();

    }
    public void Show()
    {
        UITransform.gameObject.SetActive(true);
    }
    public void Back()
    {
        IngredientManager.Instance.ingredientList.Clear();
        Debug.Log("sad");
        UITransform.gameObject.SetActive(false);
    }

    private void InitBackButton()
    {
        BackButtonTransform = UITransform.Find("OkButton");
        Button okButton = BackButtonTransform.GetComponent<Button>();
        okButton.onClick.AddListener(() => Back());
    }
}
