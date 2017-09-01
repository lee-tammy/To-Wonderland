using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int curHealth;
	public int maxHealth=10;
	public BoxCollider2D attacked;
	private gameManager2 gm;
	public bool invincible;
	private Animator player;
	// Use this for initialization
	void Start () {
		gm = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
		invincible = false;
		player = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gm.curHealth > maxHealth) {
			gm.curHealth = maxHealth;
		}
		if (gm.curHealth <= 0) {
			Invoke ("Die", 3f);
		}

	}

	void OnTriggerEnter2D(Collider2D col){
		if  ( col.CompareTag("end")){
			if (gm.useSerum) {
				Destroy (gameObject);
			}
		}
	}

	void Die(){
		if (gm.hasCageKey) {

			Application.LoadLevel (28);
		}
		gm.curHealth = maxHealth;
	}

	public IEnumerator enemy1(bool hit){
		if (hit) {
			gm.curHealth -= 1;
			invincible = true;
			player.Play ("attacked");
			yield return new WaitForSeconds (2f);
			invincible = false;
		}
	}
		
	public IEnumerator enemy2(bool hit){
		if (hit) {
			gm.curHealth -= 2;
			invincible = true;
			player.Play ("attacked");
			yield return new WaitForSeconds (2f);
			invincible = false;
		}
	}

		
		
}
