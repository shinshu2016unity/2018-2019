using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("Title1");
        }
    }
}
