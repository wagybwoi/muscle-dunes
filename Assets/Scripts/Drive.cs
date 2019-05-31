using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        if(Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene("demoscene");
        }
    }
}
