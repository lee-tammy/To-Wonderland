using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Camila : MonoBehaviour {
	private textManager tm;
	private gameManager gm;
	private Animator anim;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm=GameObject.FindGameObjectWithTag("GameManager").GetComponent<gameManager>();
		anim = GetComponent<Animator> ();
		if (gm.giveCamila) {
			anim.Play ("camila normal");
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("[Space] to Chat");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (gm.getDoll == false) {
					tm.inputText.text = ("He stole Mr. Whiskers...");
					gm.talkToCamila = true;
				} else if (gm.getDoll == true) {
					gm.giveCamila = true;
					anim.Play ("camila normal");
					tm.inputText.text = ("Thank you so much! So what did you need help with earlier?");
					Invoke ("infoAboutPete", 2f);
				}
			}
		}
	}

	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}

	void infoAboutPete(){
		tm.inputText.text=("I haven't seen Pete this whole week. He always talks and writes in his journal about this weird place. He told me he keeps it locked up in his house.");
	}

	// Use this for initialization

}
