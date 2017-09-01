using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class feedDog : MonoBehaviour {
	private gameManager gm;
	private textManager tm;
	private Animator dog;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm=GameObject.FindGameObjectWithTag("GameManager").GetComponent<gameManager>();		dog = GetComponent<Animator> ();

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (!gm.dogFed) {
				tm.inputText.text = ("[Space] to feed");
			}
		}

	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (gm.hasFood == true && !gm.dogFed) {
					dog.SetBool ("giveFood", true);
					gm.dogFed = true;
					tm.inputText.text = ("");
				} else if (gm.hasFood && gm.dogFed) {
					tm.inputText.text = ("");
				}else{
					tm.inputText.text = ("Looks like I don't have any pet food with me");
				}
			}
		}
	}


	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}

}