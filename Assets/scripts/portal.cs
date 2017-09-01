using UnityEngine;
using System.Collections;

public class portal : MonoBehaviour {
	private textManager tm;
	private gameManager gm;
	public Animator port;
	public int levelToLoad;

	void Start () {
		tm=GameObject.FindGameObjectWithTag("TextManager").GetComponent<textManager>();
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
		port = GetComponent<Animator> ();
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			if (gm.nothingHere == true) {
				port.SetBool ("near", true);
				Destroy (GameObject.FindGameObjectWithTag("Player"));
				Invoke ("leaveEarth",3f);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void leaveEarth(){
		Application.LoadLevel (levelToLoad);
	}
}
