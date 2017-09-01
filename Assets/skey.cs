using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class skey : MonoBehaviour {
	private textManager tm;
	private gameManager2 gm;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("<color=orange> Press the <b>S</b> button to attack.</color>");
		}
	}

	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
			Destroy (this.gameObject);
		}
	}


	// Use this for initialization

}

