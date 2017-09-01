using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toTownDoor : MonoBehaviour {
	public int levelToLoad;
	private textManager tm;
	private gameManager gm;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (gm.checkRoom == true&&gm.checkChest==false||gm.hasJournal==true) {
				Application.LoadLevel (levelToLoad);
			} else {
				tm.inputText.text = ("No reason for me to go to the city right now.");
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
