using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class doorToWarehouse : MonoBehaviour {
	public int levelToLoad;
	private gameManager gm;
	private textManager tm;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
				tm.inputText.text = ("[Up Arrow] to Enter");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("up")){
				if (gm.giveCamila == true) {
					Application.LoadLevel (levelToLoad);
				} else {
					tm.inputText.text = ("Mom and dad tell me not to go in here.");
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
