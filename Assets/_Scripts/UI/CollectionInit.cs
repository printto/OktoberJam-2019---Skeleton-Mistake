using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionInit : MonoBehaviour
{

    public RecipeBase[] results;
    public GameObject preFab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newObj;
        for (int i = 0; i < results.Length; i++)
        {
            newObj = (GameObject)Instantiate(preFab, transform);
            newObj.GetComponent<DexItem>().recipe = results[i];
            //newObj.GetComponentInChildren<Text>().text = results[i].creatureName;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
