using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class note : MonoBehaviour {
	private textManager tm;
	public Text textWithImage;
	public Image background;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		background.enabled =false;
		textWithImage.enabled = false;
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("[Space] to Read");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (Input.GetKeyDown ("space")) {
				EnableNoteText ();
				Invoke ("DisableJournalText", 3f);
			}
				
		}
	}

	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}

	void EnableNoteText(){
		background.enabled =true;
		textWithImage.enabled = true;
	}
	void DisableJournalText(){
		background.enabled =false;
		textWithImage.enabled = false;
	}
		

	// Use this for initialization


}