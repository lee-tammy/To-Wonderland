using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class specialDoor : MonoBehaviour {
	public int levelToLoad;
	private textManager tm;
	private gameManager gm;
	private Animator secretDoor;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
		secretDoor = GameObject.FindGameObjectWithTag ("SecretDoor").GetComponent<Animator> ();
		if (gm.hasJournal) {
			secretDoor.Play ("secretDoor");
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("[Up Arrow] to Enter");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("up")){
				if (gm.catFed == true && gm.dogFed == true) {
						tm.inputText.text = ("");
						Application.LoadLevel (levelToLoad);
				} else {
					tm.inputText.text = ("I should probably feed the dog and cat before I wake up Pete.");
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
