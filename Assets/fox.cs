using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fox: MonoBehaviour {
	private textManager tm;
	private Animator anim;
	private bool message1;
	private bool message2;
	private gameManager2 gm2;
	private bool message3;
	public BoxCollider2D foxTrigger;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm2 = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
		anim = GetComponent<Animator> ();
		foxTrigger.enabled = false;
		anim.Play ("fox alert");
		message1 = false;
		message2 = false;
		message3 = false;

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("[Space] to Chat");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (gm2.openCage) {
					EnableText ();
					Invoke ("DisableText", 3f);
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
		if (!message1) {
			message1 = true;
			tm.inputText.text = ("<color=orange>Thanks! So, what brings you in our world, <b>Alice<b>?</color>");
		} else if (!message2) {
			message2 = true;
			tm.inputText.text = ("<color=orange>Oh, Pete?! I know him! He promised he would visit me this week, but he hasn't yet. You don't know where he is?</color>");
		} else if (!message3) {
			tm.inputText.text = ("<color=orange>I've been separated from my family. We can help each other look for our family.</color>");
			message3 = true;
		} else {
			tm.inputText.text = ("<color=orange>Go on.. I'll catch up with you</color>");
			gm2.talkToFox = true;
		}
	}

	void DisableText(){
		tm.inputText.text = ("");
	}

	void Update(){
		if (gm2.openCage) {
			anim.Play ("fox stand");
			foxTrigger.enabled = true;
		}
	}

	// Use this for initialization

}
