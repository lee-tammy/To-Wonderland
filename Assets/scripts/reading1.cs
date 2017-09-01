using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class reading1 : MonoBehaviour {
	private textManager tm;
	private gameManager gm;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(gm.hasJournal==true){
				tm.inputText.text=("The Book of Spells.");
			}
		}
	}

	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
			Destroy (this.gameObject);
		}
	}


	// Use this for initialization

}
