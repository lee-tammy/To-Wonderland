using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class panda: MonoBehaviour {
	private textManager tm;
	private gameManager2 gm;
	public Image obtainedSerumBackground;
	public Image serumImage;
	public Text obtainedSerumWords;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
		obtainedSerumBackground.enabled = false;
		serumImage.enabled = false;
		obtainedSerumWords.enabled = false;
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("[Space] to Chat");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (!gm.hasFlower&& gm.checkVines) {
					tm.inputText.text = ("Get rid of the vines? I can make you a serum, but I'm missing an ingredient. Go to the right and fetch me a purple flower");
					gm.talkToPanda = true;
				} else if (gm.hasFlower && !gm.getSerum) {
					tm.inputText.text = ("Here, pour this on the vines. It should dissolve.");
					gm.getSerum = true;
					EnableSerumText ();
					Invoke ("DisableSerumText", 2f);
					tm.inputText.text = ("");
				} else {
					tm.inputText.text = ("I'm busy....");
				}
			}
		}
	}

	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}

	void EnableSerumText(){
		obtainedSerumBackground.enabled = true;
		obtainedSerumWords.enabled = true;
		serumImage.enabled = true;
	}
	void DisableSerumText(){
		obtainedSerumBackground.enabled = false;
		obtainedSerumWords.enabled = false;
		serumImage.enabled = false;

	}

	// Use this for initialization

}
