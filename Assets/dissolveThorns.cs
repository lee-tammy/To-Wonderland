using UnityEngine;
using System.Collections;

public class dissolveThorns : MonoBehaviour {
	private textManager tm;
	private gameManager2 gm;
	// Use this for initialization
	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm=GameObject.FindGameObjectWithTag("GameManager2").GetComponent<gameManager2>();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (gm.getSerum) {
				tm.inputText.text = ("[Space] to use serum");
			} else if (gm.openCage && !gm.checkVines) {
				tm.inputText.text = ("[Space] to inspect");
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (gm.getSerum) {
					gm.useSerum = true;
					tm.inputText.text = ("");
					Destroy (gameObject);
				} else if (gm.openCage && !gm.getSerum) {
					gm.checkVines = true;
					tm.inputText.text = ("I can't go through. The thorns are blocking the path.");
				}

			}
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text = ("");

		}
	}
	// Update is called once per frame
	void Update () {
		
	
	}
}
