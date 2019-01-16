using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltConveir : MonoBehaviour {
    [SerializeField]
    private float speed = 1f;    //速度設定
    public Vector3 ConveyorVelocity()
    {
        return transform.forward * speed;
    }


    // Use this for initialization
    void Start() {
        
    }
	
	// Update is called once per frame
	void Update () {

	}
}
