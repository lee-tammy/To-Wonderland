using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class lastReading : MonoBehaviour {
	private textManager tm;
	private gameManager gm;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(gm.hasJournal==true){
				gm.nothingHere = true;
				tm.inputText.text=("There's nothing here.");
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
