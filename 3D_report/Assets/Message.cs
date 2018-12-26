using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message : MonoBehaviour {
    //public string textToEdit = "Textfield";	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string textToEdit = "メッセージを入力";
void OnGUI()
    {
        // テキストエリアを表示する
        textToEdit = GUI.TextArea(new Rect(10, 10, 250, 100), textToEdit);
    }
}
