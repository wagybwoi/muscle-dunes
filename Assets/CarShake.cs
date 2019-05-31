using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarShake : MonoBehaviour
{
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(transform.localPosition.x, initialPosition.y + Random.value * 2f, transform.localPosition.z), 0.05f);
        transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles, new Vector3(Random.value * 5f, transform.localEulerAngles.y, transform.localEulerAngles.z), 0.02f);
    }
}
