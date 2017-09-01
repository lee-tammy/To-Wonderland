using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class keyLocation : MonoBehaviour {
	private gameManager gm;
	private textManager tm;
	public Image foundKeyBackground;
	public Image keyImage;
	public Text foundKeyWords;

	// Use this for initialization
	void Start () {
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
		tm = GameObject.FindGameObjectWithTag ("TextManager").GetComponent<textManager> ();
		foundKeyBackground.enabled = false;
		keyImage.enabled = false;
		foundKeyWords.enabled = false;
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (gm.checkChest&&gm.hasKey==false) {
				tm.inputText.text = ("[Space] to search for key");
			}
		}

	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (gm.checkChest==true&&gm.hasKey==false) {
				if (Input.GetKeyDown ("space")) {
					gm.hasKey = true;
					EnableText ();
					Invoke ("DisableText", 2f);
					tm.inputText.text=("");
				}
			}
		}
	}


	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}
	void EnableText(){
		foundKeyBackground.enabled = true;
		keyImage.enabled = true;
		foundKeyWords.enabled = true;
	}
	void DisableText(){
		foundKeyBackground.enabled = false;
		keyImage.enabled = false;
		foundKeyWords.enabled = false;
	}
}
