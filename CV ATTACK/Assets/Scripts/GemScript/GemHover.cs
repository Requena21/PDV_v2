using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemHover : MonoBehaviour
{

    private float startY;
    private float speed = 2f;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        Vector3 position = transform.position;
        position = new Vector3(position.x, startY + Mathf.Sin(Time.time * speed) * 0.1f, position.z);
        transform.position = position;
    }
}
