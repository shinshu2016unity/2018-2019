﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする


public class StartToGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("CreateGame"); //ゲーム画面
        }
    }
}