using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bunny: MonoBehaviour {
	private textManager tm;
	private gameManager2 gm;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm=GameObject.FindGameObjectWithTag("GameManager2").GetComponent<gameManager2>();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("[Space] to Chat");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (gm.openCage && !gm.checkVines) {
					tm.inputText.text = ("Continue the path to go to the queen's castle. She may know about his whereabouts.");
				} else if (gm.checkVines&&!gm.getSerum) {
					tm.inputText.text = ("Find the panda in the dark woodlands. He should know how to get rid of the vines.");
				} else {
					tm.inputText.text = ("Be careful. The queen is... not as welcoming as us.");
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
