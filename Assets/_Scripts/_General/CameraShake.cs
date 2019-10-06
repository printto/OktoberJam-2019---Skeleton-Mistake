using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake
{
    private Transform CameraTransform;

    private float shakeDuration = 0f;

    private float shakeMagnitude = 10f;

    private float dampingSpeed = 1.5f;

    Vector3 initialPosition;
    public void Start(GameObject parentCanvas)
    {
        CameraTransform = parentCanvas.transform.Find("Camera");
        initialPosition = this.CameraTransform.localPosition;

    }
    public void Update()
    {
        if (shakeDuration > 0)
        {
            CameraTransform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            shakeDuration = 0f;
            CameraTransform.localPosition = initialPosition;
        }
    }

    public void TriggerShake(float duration, float shakePower)
    {
        shakeDuration = duration;
        shakeMagnitude = shakePower;
    }
}
