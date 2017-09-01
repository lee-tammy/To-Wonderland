using UnityEngine;
using System.Collections;

public class enemy1 : MonoBehaviour {
	public int health;
	public Animator anim;
	public int curHealth;
	public Transform item;
	public bool dropKey;
	public BoxCollider2D playerBox;
	private Player player;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		curHealth = health;
		dropKey = false;
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (curHealth <= 0) {
			anim.Play ("enemy1 die");
			Invoke("DestroyObject",1.5f);
			if (!dropKey) {
				Instantiate(item, new Vector3 (transform.position.x, 3.3f, 0), Quaternion.identity);
				dropKey = true;
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if  ( col.CompareTag("Player")){
			if (player.invincible == false) {
				col.SendMessageUpwards ("enemy1", true);
			}
		}
	}

	public void Damage(int damage){
		curHealth -= damage;
		if (curHealth >= damage) {
			Invoke ("hitAnimation", 0.3f);
		}
	}

	void DestroyObject(){
		Destroy(gameObject);
	}
	void hitAnimation(){
		anim.Play ("enemy1 hit");
	}
}
