using UnityEngine;
using System.Collections;

public class playerAttack : MonoBehaviour {
	private bool attacking=false;
	private float attackCD=0.5f;
	public BoxCollider2D attackTrigger;
	public Animator anim;

	private float attackTimer=0;
	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator> ();
		attackTrigger.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("s") && !attacking) {
			attacking = true;
			attackTimer = attackCD;
			attackTrigger.enabled = true;
		}
		if(attacking){
			if(attackTimer>0){
				attackTimer -= Time.deltaTime;
			}else{
				attacking=false;
				attackTrigger.enabled=false;
			}
		}
		anim.SetBool ("attacking", attacking);
	}


}
