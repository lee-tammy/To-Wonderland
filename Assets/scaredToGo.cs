using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scaredToGo : MonoBehaviour {
	public int levelToLoad;
	private textManager tm;
	private gameManager2 gm;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (gm.checkVines) {
				Application.LoadLevel (levelToLoad);
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (!gm.checkVines) {
				tm.inputText.text = ("The dark woodlands sound scary. I should go to the tea house.");
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
