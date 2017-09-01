using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class feedCat : MonoBehaviour {
	private gameManager gm;
	private textManager tm;
	private Animator cat;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm=GameObject.FindGameObjectWithTag("GameManager").GetComponent<gameManager>();		
		cat = GetComponent<Animator> ();

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (!gm.catFed) {
				tm.inputText.text = ("[Space] to feed");
			}
		}

	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (gm.hasFood == true&&!gm.catFed){
					cat.SetBool("giveFood", true);
					gm.catFed = true;
					tm.inputText.text =("");
				} else if (gm.hasFood && gm.catFed) {
					tm.inputText.text = ("");
				} else {
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