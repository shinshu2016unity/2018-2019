using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCount : MonoBehaviour {
    public Text TimerText;
    public float TotalTime;
    int seconds;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TotalTime -= Time.deltaTime;
        seconds = (int)TotalTime;
        TimerText.text = seconds.ToString();
        if(seconds == 0)
        {
            SceneManager.LoadScene("end1");
        }
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("title1");
        }
	}
}
