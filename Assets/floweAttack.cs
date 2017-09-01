using UnityEngine;
using System.Collections;

public class floweAttack : MonoBehaviour {
	private gameManager2 gm;
	private bool attacking=true;
	private float attackCD=2f;
	public BoxCollider2D flowerTrigger;
	public Animator anim;
	public int damage;
	private Player player;
	public float timeStart;

	private float attackTimer=0;
	// Use this for initialization
	void Awake () {
		gm = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
		anim = GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
	}

//	// Update is called once per frame
//	void Update () {
//		if (attacking) {
//			anim.SetBool ("attacking", true);
//			attackTimer = attackCD;
//			Invoke ("attack", 3f);
//		}
//		if(!attacking){
//			if(attackTimer>0){
//				attackTimer -= Time.deltaTime;
//			}else{
//				attacking=true;
//				flowerTrigger.enabled=true;
//			}
//		}
//
//	}

	void OnTriggerEnter2D(Collider2D col){
		if  ( col.CompareTag("Player")){
			if (player.invincible == false) {
				col.SendMessageUpwards ("enemy2", true);
			}
		}
	}
//	void attack(){
//		flowerTrigger.enabled = false;
//		attacking = false;
//		anim.SetBool ("attacking", false);
//	}
//		
	void playIt(){
		anim.Play ("flower stand");
	}
}
