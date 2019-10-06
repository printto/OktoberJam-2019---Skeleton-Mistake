using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateGrid : MonoBehaviour
{
    public GameObject CollectionImage;
    public int CollectionAmount;
    private void OnEnable()
    {
        Populate();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Populate()
    {
        GameObject newObj;
        //CollectionAmount = IngredientManager.Instance.ingredientList.Count;
        for (int i = 0; i < CollectionAmount; i++)
        {
            newObj = (GameObject)Instantiate(CollectionImage, transform);
            newObj.GetComponent<Image>().color = Random.ColorHSV();
        }
    }
}
