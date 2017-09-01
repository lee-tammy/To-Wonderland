using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pickUpFood : MonoBehaviour {
	private gameManager gm;
	private textManager tm;
	public Image obtainedPetFoodBackground;
	public Image petFoodImage;
	public Text obtainedPetFoodWords;
	private GameObject collider;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm=GameObject.FindGameObjectWithTag("GameManager").GetComponent<gameManager>();
		obtainedPetFoodBackground.enabled = false;
		petFoodImage.enabled = false;
		obtainedPetFoodWords.enabled = false;

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Pick Up")){
			tm.inputText.text=("[Space] to pick up pet food");
		}
		if (col.CompareTag ("Brother Missing Message")) {
			tm.inputText.text = ("Where is he? Maybe he sneaked out to the city when I was feeding the pets. I should probably go look for him.");
		}
	}

	void OnTriggerStay2D(Collider2D col){
		collider = col.gameObject;
		if(col.CompareTag("Pick Up")){
			if(Input.GetKeyDown("space")){
				gm.hasFood = true;
				Destroy(col.gameObject);
				EnablePetFoodText ();
				Invoke ("DisablePetFoodText", 2f);
				tm.inputText.text=("");
			}
		}
		if(col.CompareTag("Brother Missing Message")){
			Invoke ("DestroyObject", 3f);

		}
	}
					

	void OnTriggerExit2D(Collider2D col){

		if(col.CompareTag("Pick Up")){
			tm.inputText.text=("");
		}
		if(col.CompareTag("Brother Missing Message")){
			tm.inputText.text=("");
		}
	}

	void EnablePetFoodText(){
		obtainedPetFoodBackground.enabled = true;
		obtainedPetFoodWords.enabled = true;
		petFoodImage.enabled = true;
	}
	void DisablePetFoodText(){
		obtainedPetFoodBackground.enabled = false;
		obtainedPetFoodWords.enabled = false;
		petFoodImage.enabled = false;
	}
		
	void DestroyObject(){
		gm.checkRoom = true;
		Destroy (collider);
		tm.inputText.text=("");
	}
	void Update () {
		if (gm.hasFood) {
			GameObject.FindGameObjectWithTag ("Pick Up").SetActive (false);
		}
	}
		
}

