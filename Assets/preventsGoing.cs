using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class preventsGoing : MonoBehaviour {
	public int levelToLoad;
	private textManager tm;
	private gameManager gm;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (!gm.hasJournal) {
				Application.LoadLevel (levelToLoad);
			}
		}
	}
	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (gm.hasJournal) {
				tm.inputText.text = ("I'm curious about the shining light in the bushes.");
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
