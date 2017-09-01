using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class glint : MonoBehaviour {
	public int levelToLoad;
	private textManager tm;
	private gameManager gm;
	private Animator secretDoor;
	private bool inspected;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
		secretDoor = GameObject.FindGameObjectWithTag ("Secret Door").GetComponent<Animator> ();
		inspected = false;
		if (gm.hasJournal) {
			secretDoor.Play ("secretDoor");
		} else {
			GameObject.FindGameObjectWithTag ("Secret Door").SetActive (false);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (gm.hasJournal==true) {
				tm.inputText.text = ("[Space] to Inspect");
				if (inspected == true) {
					tm.inputText.text = ("[Up Arrow] to Enter");
				}
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (gm.hasJournal == true) {
					tm.inputText.text = ("Looks like something there's something here");
					inspected = true;
					Invoke ("go", 2f);
				}
			}
			if(Input.GetKeyDown("up")){
				if (gm.hasJournal==true&&inspected) {
					Application.LoadLevel (levelToLoad);
				} else {
					tm.inputText.text = ("");
				}
			}
		}
	}

	void go(){
		tm.inputText.text = ("[Up Arrow] to Enter");
	}

	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}


	// Use this for initialization

}
