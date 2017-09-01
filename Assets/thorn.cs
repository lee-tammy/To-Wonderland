using UnityEngine;
using System.Collections;

public class thorn : MonoBehaviour {
	private gameManager2 gm;
	public int damage;
	private Player player;
	// Use this for initialization
	void Start () {
		gm = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
	}


	void OnTriggerStay2D(Collider2D col){
		if  ( col.CompareTag("Player")){
			if (player.invincible == false) {
				col.SendMessageUpwards ("enemy1", true);
			}
		}
	}



	void Update(){
		if(gm.useSerum){
			Destroy (gameObject);
		}
	}

}
