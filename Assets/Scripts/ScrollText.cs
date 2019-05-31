using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollText : MonoBehaviour
{
    private RectTransform rt;
    public float speed = 0.1f;

    void Start()
    {
        rt = this.GetComponent<RectTransform>();
        speed = -(Random.value + 0.1f) * speed;
    }

    void Update()
    {
        rt.localPosition = new Vector3(rt.localPosition.x + (speed / Time.deltaTime), rt.localPosition.y, rt.localPosition.z);
    }
}
