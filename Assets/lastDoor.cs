using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class lastDoor : MonoBehaviour {
	public int levelToLoad;
	private textManager tm;
	private gameManager2 gm;


	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (gm.useSerum) {
				gm.done = true;
				Invoke ("leave", 3f);
			}
		}
	}



	void OnTriggerExit2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}

	void leave(){
		Application.LoadLevel (levelToLoad);
	}


	// Use this for initialization

}
