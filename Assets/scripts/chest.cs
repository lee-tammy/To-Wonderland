using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class chest: MonoBehaviour {
	public int levelToLoad;
	private textManager tm;
	private gameManager gm;
	public Text obtainedJournalWords;
	public Image obtainedJournalBackground;
	public Image journalImage;
	private Animator anim;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
		obtainedJournalWords.enabled = false;
		obtainedJournalBackground.enabled = false;
		journalImage.enabled = false;
		anim = GetComponent<Animator> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (!gm.openChest) {
				tm.inputText.text = ("[Space] to Open");
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (!gm.hasKey) {
					tm.inputText.text = ("It's locked. The key should be somewhere in the house.");
					gm.checkChest = true;
				} else if(gm.hasKey&& !gm.openChest){
					gm.openChest = true;
					gm.hasJournal = true;
					anim.SetBool ("hasKey", true);
					EnableJournalText ();
					Invoke ("DisableJournalText", 2f);
				}
					
			}
		}
	}

	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}

	void EnableJournalText(){
		obtainedJournalBackground.enabled = true;
		obtainedJournalWords.enabled = true;
		journalImage.enabled = true;
	}
	void DisableJournalText(){
		obtainedJournalBackground.enabled = false;
		obtainedJournalWords.enabled = false;
		journalImage.enabled = false;
	}


	// Use this for initialization

}
