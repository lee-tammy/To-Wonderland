using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Soliloquy : MonoBehaviour {
	private gameManager2 gm;
	private textManager tm;

	// Use this for initialization
	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm=GameObject.FindGameObjectWithTag("GameManager2").GetComponent<gameManager2>();
		tm.inputText.text = ("Where am I?");
		Invoke ("DisableText", 3f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void DisableText(){
		tm.inputText.text = ("");
	}
}
