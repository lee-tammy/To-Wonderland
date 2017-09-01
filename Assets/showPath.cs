using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showPath : MonoBehaviour {
	private textManager tm;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("[Space] to Read");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (Input.GetKeyDown ("space")) {
				tm.inputText.text = ("The dark woodlands is on the <b>left</b>. The tea house is on the <b>right</b>.");
			}
		}
	}

	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}
		

	// Use this for initialization


}