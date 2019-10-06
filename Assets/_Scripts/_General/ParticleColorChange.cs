using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleColorChange : MonoBehaviour
{
    private ParticleSystem ps;
    void Start()
    {
        ps = GetComponent<ParticleSystem>();

    }

    void Update()
    {
        var main = ps.main;
        main.startColor = Random.ColorHSV();
    }
}
