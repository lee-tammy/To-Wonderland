using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class keyPickUp : MonoBehaviour {
	private gameManager2 gm;
	private textManager tm;
	public Image obtainedKeyToCageBackground;
	public Image KeyToCageImage;
	public Text obtainedKeyToCageWords;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm=GameObject.FindGameObjectWithTag("GameManager2").GetComponent<gameManager2>();
		obtainedKeyToCageBackground.enabled = false;
		KeyToCageImage.enabled = false;
		obtainedKeyToCageWords.enabled = false;

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (!gm.hasCageKey) {
				tm.inputText.text = ("[Space] to pick up key");
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				gm.hasCageKey = true;
				EnableKeyToCageText ();
				Invoke ("DisableKeyToCageText", 2f);
				tm.inputText.text=("");

			}
		}
	}


	void OnTriggerExit2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
			
	}

	void EnableKeyToCageText(){
		obtainedKeyToCageBackground.enabled = true;
		obtainedKeyToCageWords.enabled = true;
		KeyToCageImage.enabled = true;
	}
	void DisableKeyToCageText(){
		obtainedKeyToCageBackground.enabled = false;
		obtainedKeyToCageWords.enabled = false;
		KeyToCageImage.enabled = false;
		Destroy(gameObject);

	}
		

}

