using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin2Win : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Rotate(new Vector3(speed, 0f, 0f));
    }
}
