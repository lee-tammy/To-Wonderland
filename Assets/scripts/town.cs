using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class town : MonoBehaviour {
	public int levelToLoad;
	private textManager tm;
	private gameManager gm;
	private gameManager2 gm2;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			Application.LoadLevel (levelToLoad);
		}
	}



	void OnTriggerExit2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}


	// Use this for initialization

}
