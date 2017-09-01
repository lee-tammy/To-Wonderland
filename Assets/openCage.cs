using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class openCage : MonoBehaviour {
	private gameManager2 gm;
	private textManager tm;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm=GameObject.FindGameObjectWithTag("GameManager2").GetComponent<gameManager2>();

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("[Space] to open");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (gm.hasCageKey) {
					tm.inputText.text = ("");
					gm.openCage = true;
					Destroy (gameObject);
				}else{
					tm.inputText.text=("<color=orange>What are you doing!? Attack him!</color>");
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

