using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.localPosition;
    }

    void Update()
    {
        transform.position += transform.forward * (speed / Time.deltaTime);
        // transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(transform.localPosition.x, startPosition.y + Random.value * 100f, transform.localPosition.z), 0.1f);
    }
}
