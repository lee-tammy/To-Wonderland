using UnityEngine;
using System.Collections;

public class searchForKey : MonoBehaviour {
	private gameManager gm;
	private textManager tm;
	// Use this for initialization
	void Start () {
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
		tm = GameObject.FindGameObjectWithTag ("TextManager").GetComponent<textManager> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (gm.checkChest&&gm.hasKey==false) {
				tm.inputText.text = ("[Space] to search for key");
			}
		}

	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (Input.GetKeyDown ("space")) {
				if (gm.checkChest == true && gm.hasKey == false) {
					tm.inputText.text = ("No key here.");
				}
			}
		}
	}


	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}
}
