using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour {
    public float sign;
    public int low, high;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        float ypos = transform.position.y;
        if (ypos < low || ypos > high) sign *= -1f;
        Vector3 mv  = new Vector3(0f,0.1f*sign,0f);
        transform.Translate(mv);
    }
}
