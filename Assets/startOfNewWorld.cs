using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class startOfNewWorld : MonoBehaviour {
	public int levelToLoad;
	private textManager tm;
	private gameManager2 gm2;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm2 = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (gm2.openCage && gm2.talkToFox) {
				Application.LoadLevel (levelToLoad);
			} else if (!gm2.openCage) {
				tm.inputText.text = ("I need to help that fox.");
			} else {
				tm.inputText.text = ("I should talk to the fox.");
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
