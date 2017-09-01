using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {
	public bool hasFood;
	public bool dogFed;
	public bool catFed;
	public bool checkRoom;
	public bool talkToCamila;
	public bool talkToBoy;
	public bool goUpstairs;
	public bool hasSword;
	public bool getDoll;
	public bool giveCamila;
	public bool checkChest;
	public bool hasKey;
	public bool openChest;
	public bool hasJournal;
	public bool nothingHere;

	public Image introBackground;
	public Text introWords;



	// Use this for initialization
	void Start () {
		hasFood = false;
		dogFed = false;
		catFed = false;
		checkRoom = false;
		talkToCamila = false;
		talkToBoy = false;
		goUpstairs = false;
		hasSword = false;
		getDoll = false;
		giveCamila = false;
		checkChest = false;
		hasKey = false;
		openChest = false;
		hasJournal = false;
		nothingHere = false;



	}
	void Awake(){
		DontDestroyOnLoad (this);
		GameObject.FindGameObjectWithTag ("Secret Door").SetActive (false);
		if (nothingHere) {
			Destroy (this);
		}

	}

	// Update is called once per frame
	void Update () {
		if (checkRoom) {
			GameObject.FindGameObjectWithTag ("Brother Missing Message").SetActive (false);
		}
		if (hasKey) {
			GameObject.FindGameObjectWithTag ("Key Hiding Spot").SetActive (false);
		}
		if (hasJournal) {
			GameObject.FindGameObjectWithTag ("Door").SetActive (false);
			GameObject.FindGameObjectWithTag ("Secret Door").SetActive (true);
		}
	}



			
		//inputText.text = ("" + inputText);
}
