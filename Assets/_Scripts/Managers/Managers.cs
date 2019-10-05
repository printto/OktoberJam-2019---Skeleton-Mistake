using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers 
{
    public static Managers Instance;
    public UIManager m_UIManager;

    public Managers()
    {
        m_UIManager = new UIManager();

        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void Start(GameObject parentCanvas)
    {
        m_UIManager.Start(parentCanvas);      
    }

    public void Update()
    {
        m_UIManager.Update();
    }
}
