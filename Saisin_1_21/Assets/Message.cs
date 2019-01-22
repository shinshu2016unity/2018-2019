using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする


public class Message : MonoBehaviour {
    //public string textToEdit = "Textfield";	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space") || Input.GetButtonDown("Action1") || Input.GetButtonDown("Jump")) //マウス左クリック、スペースキー、Aボタン、ジャンプボタンを押した場合

        {

            SceneManager.LoadScene("end1");//end1シーンをロードする

        }
    }

    public string textToEdit = "メッセージを入力";
void OnGUI()
    {
        // テキストエリアを表示する
        textToEdit = GUI.TextArea(new Rect(10, 10, 250, 100), textToEdit);
    }
}
