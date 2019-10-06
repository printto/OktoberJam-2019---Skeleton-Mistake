using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
