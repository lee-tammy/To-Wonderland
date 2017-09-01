using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {
	public bool facingLeft;
	private Animator anim;
	private movemen playerMovement;
	private Rigidbody2D foxRigidbody;
	public float movementSpeed;


	void Start () {
		facingLeft = true;
		playerMovement = GameObject.FindGameObjectWithTag ("Player").GetComponent<movemen> ();
		foxRigidbody = GetComponent<Rigidbody2D> ();
	}

	void Update(){
		if (playerMovement.facingLeft) {
			
		}
		//rotate to look at the player



		//move towards the player

	}
	public void handleMovement(float horizontal){
			foxRigidbody.velocity = new Vector2 (horizontal * movementSpeed, foxRigidbody.velocity.y);
			anim.SetFloat ("speed", Mathf.Abs(horizontal));
	}
	public void Flip(float horizontal){
		if(horizontal>0 &&facingLeft ||horizontal<0 &&!facingLeft){
			facingLeft=!facingLeft;
			Vector3 theScale =transform.localScale;
			theScale.x*=-1;
			transform.localScale=theScale;
		}
	}

}