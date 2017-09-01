using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class boy : MonoBehaviour {
	private textManager tm;
	private gameManager gm;
	public Image obtainedDollBackground;
	public Image dollImage;
	public Text obtainedDollWords;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm=GameObject.FindGameObjectWithTag("GameManager").GetComponent<gameManager>();
		obtainedDollBackground.enabled = false;
		dollImage.enabled = false;
		obtainedDollWords.enabled = false;
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("[Space] to Chat");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (gm.talkToCamila == true&&gm.hasSword==false) {
					tm.inputText.text = ("I found this doll on the floor, so it's mine. Tell you what.. I'll make a deal with you. If you can get me a sword, I'll give her doll back.");
					gm.talkToBoy = true;
				} else if (gm.hasSword == true&&!gm.giveCamila) {
					tm.inputText.text = ("Wow, you actually got the sword for me. Here's the doll.");
					gm.getDoll = true;
					EnableDollText ();
					Invoke ("DisableDollText", 2f);
				} else {
					tm.inputText.text = ("I don't know him.");
				}
			}
		}
	}

	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}

	void EnableDollText(){
		obtainedDollBackground.enabled = true;
		obtainedDollWords.enabled = true;
		dollImage.enabled = true;
	}
	void DisableDollText(){
		obtainedDollBackground.enabled = false;
		obtainedDollWords.enabled = false;
		dollImage.enabled = false;
	}


	// Use this for initialization

}
