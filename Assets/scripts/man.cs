using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class man: MonoBehaviour {
	private textManager tm;
	private gameManager gm;
	public Text obtainedSwordWords;
	public Image swordImage;
	public Image obtainedSwordBackground;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm=GameObject.FindGameObjectWithTag("GameManager").GetComponent<gameManager>();
		obtainedSwordWords.enabled = false;
		obtainedSwordBackground.enabled = false;
		swordImage.enabled = false;
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("[Space] to Chat");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if(gm.goUpstairs==true&&gm.hasSword==false){
					tm.inputText.text=("Here, take it. I don't need anything in return.");

					EnableSwordText();
					Invoke("DisableSwordText",3f);
				}else if (gm.talkToBoy == true&&gm.goUpstairs==false) {
					tm.inputText.text = ("Hm... I think I might have one sitting in my house. Let me check upstairs");
					Invoke ("GoUpstairs", 2f);
				} else {
					tm.inputText.text = ("Hey!");
				}
			}
		}
	}

	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}
	}

		void EnableSwordText(){
			obtainedSwordBackground.enabled = true;
			obtainedSwordWords.enabled = true;
			swordImage.enabled = true;
		}
		void DisableSwordText(){
			obtainedSwordBackground.enabled = false;
			obtainedSwordWords.enabled = false;
			swordImage.enabled = false;
			gm.hasSword = true;
		}
	void GoUpstairs(){
		tm.inputText.text=("");
		gm.goUpstairs = true;
		Destroy (this.gameObject);
	}


	// Use this for initialization

}
