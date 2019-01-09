using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    private GameObject Subcamera;
    // Use this for initialization
    void Start()
    {
        Subcamera = GameObject.Find("Subcamera");
        
    }

    // Update is called once per frame
    public Camera cam;
    void Update()
    {
        if(transform.position.y < 900)
        { 
            transform.Translate(new Vector3(0, 1f, 0)); //上昇
            transform.Rotate(new Vector3(0, 1, 0));//回転
        }
        else
        {
            Subcamera.SetActive(false);
        }

    }
}
