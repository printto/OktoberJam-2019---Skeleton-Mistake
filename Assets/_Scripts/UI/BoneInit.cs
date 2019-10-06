using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoneInit : MonoBehaviour
{
    public IngredientBase[] Bones;
    public GameObject preFab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newObj;
        for (int i = 0; i < Bones.Length; i++)
        {
            newObj = (GameObject)Instantiate(preFab, transform);
            newObj.GetComponentInChildren<IngredientObject>().ingredientScript = Bones[i];
            newObj.AddComponent<ToolTip>();
            newObj.GetComponent<ToolTip>().toolTipInfo = newObj.GetComponentInChildren<IngredientObject>().ingredientScript.ingredientName;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
