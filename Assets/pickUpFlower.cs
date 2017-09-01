using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pickUpFlower : MonoBehaviour {
	private gameManager2 gm;
	private textManager tm;
	public Image obtainedFlowerBackground;
	public Image flowerImage;
	public Text obtainedFlowerWords;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm=GameObject.FindGameObjectWithTag("GameManager2").GetComponent<gameManager2>();
		obtainedFlowerBackground.enabled = false;
		flowerImage.enabled = false;
		obtainedFlowerWords.enabled = false;

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (gm.talkToPanda&&!gm.hasFlower) {
				tm.inputText.text = ("[Space] to collect flower");
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.CompareTag("Player")){
			if(Input.GetKeyDown("space")){
				if (gm.talkToPanda && !gm.hasFlower) {
					gm.hasFlower = true;
					EnableFlowerText ();
					Invoke ("DisableFlowerText", 2f);
					tm.inputText.text = ("");
				}

			}
		}
	}


	void OnTriggerExit2D(Collider2D col){
		if(col.CompareTag("Player")){
			tm.inputText.text=("");
		}

	}

	void EnableFlowerText(){
		obtainedFlowerBackground.enabled = true;
		obtainedFlowerWords.enabled = true;
		flowerImage.enabled = true;
	}
	void DisableFlowerText(){
		obtainedFlowerBackground.enabled = false;
		obtainedFlowerWords.enabled = false;
		flowerImage.enabled = false;
		Destroy(gameObject);

	}


}

