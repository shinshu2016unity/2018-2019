using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{

    private Rigidbody rb;
    private Vector3 defaultPos;
    public float idou = 5f;
    private float time1;
    public float time2 = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        defaultPos = transform.position;
    }

    void FixedUpdate()
    {
        time1 = Time.time * time2;
        rb.MovePosition(new Vector3(defaultPos.x + Mathf.PingPong(time1, idou), defaultPos.y, defaultPos.z));
    }

}
