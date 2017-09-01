using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cantGoDoor : MonoBehaviour {
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
				tm.inputText.text = ("[Up Arrow] to Enter");
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("up")){
				if (!gm.hasJournal) {
					Application.LoadLevel (levelToLoad);
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
