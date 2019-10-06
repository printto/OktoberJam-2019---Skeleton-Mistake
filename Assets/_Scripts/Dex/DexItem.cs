using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DexItem : MonoBehaviour
{

    public RecipeBase recipe;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Image>().sprite = recipe.successSprite;
        if (!DexList.Instance.dexList.Contains(recipe))
        {
            gameObject.GetComponent<Image>().color = new Color(0, 0, 0);
        }
    }

}
