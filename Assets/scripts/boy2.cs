using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class boy2: MonoBehaviour {
	private textManager tm;
	private gameManager gm;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("[Space] to Chat");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (gm.talkToBoy == true&&gm.hasSword==false) {
					tm.inputText.text = ("I usually buy my toys in the store in front of me.");
				} else {
					tm.inputText.text = ("Hi!");
				}
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
