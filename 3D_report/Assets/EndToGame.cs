using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする


public class EndToGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1)) //右クリック
        {
            SceneManager.LoadScene("Unity1"); //ゲーム画面
        } else if (Input.GetKeyDown("space")) //aボタン
        {
            Debug.Log("aaa");
            SceneManager.LoadScene("Title1");
        }
    }
}
