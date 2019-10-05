using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagersBehavior : MonoBehaviour
{
    private Managers managers;

    private void Awake()
    {
        managers = new Managers();
    }
    void Start()
    {
        managers.Start(this.gameObject);
    }

    void Update()
    {
        managers.Update();
    }
}
