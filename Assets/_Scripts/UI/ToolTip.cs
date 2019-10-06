using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string toolTipInfo; //Text That Will Show ToolTip
    public Text toolTipObject;

    bool isOver = false;

    // Use this for initialization
    void Start()
    {
        if (GameObject.Find("ToolTip"))
        {
            toolTipObject = GameObject.Find("ToolTip").GetComponent<Text>();
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        if(toolTipObject != null)
        {
            /*
            if (isOver) // Starting point, direction, distance, layer to interact with
            {
                ShowInfo(toolTipInfo); //Pass Name Of Object To Method
            }
            */
            toolTipObject.transform.position = Input.mousePosition + new Vector3(180f,-50f,0f); //Move Text To Mouse's Position
            /*
            else
            {
                ShowInfo(""); //Turn Off Text When Mouse Isn't Over Appropriate Collider
            }
            */
        }
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Mouse enter");
        ShowInfo(toolTipInfo);
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Mouse exit");
        ShowInfo("");
    }

    void ShowInfo(string name)
    {
        Debug.Log(name);

        toolTipObject.text = name; //Update Text

        toolTipObject.transform.position = Input.mousePosition; //Move Text To Mouse's Position
    }
}
