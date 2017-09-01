using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameManager2 : MonoBehaviour {
	
	private Player player;
	public int curHealth;

	public bool newWorld;
	public bool hasCageKey;
	public bool openCage;
	public bool talkToFox;
	public bool checkVines;
	public bool hasFlower;
	public bool talkToPanda;
	public bool getSerum;
	public bool useSerum;
	public bool done;



	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
		curHealth = player.maxHealth;
		newWorld = true;
		hasCageKey = false;
		openCage = false;
		talkToFox = false;
		checkVines = false;
		hasFlower = false;
		talkToPanda = false;
		getSerum = false;
		useSerum = false;
		done = false;


	}
	void Awake(){
		DontDestroyOnLoad (this);
	}

	void Update(){
		if (hasFlower) {
			GameObject.FindGameObjectWithTag ("purple").SetActive (false);
		}
		if (useSerum) {
			GameObject.FindGameObjectWithTag ("thorn").SetActive (false);

		}

		if (done==true) {
			Destroy (gameObject);
		}

	}




}
