using UnityEngine;
using System.Collections;

public class movementWithFaint : MonoBehaviour {
	private Rigidbody2D myRigidbody;
	private gameManager2 gm;

	[SerializeField]
	private float movementSpeed;
	private bool facingLeft;
	private Animator anim;
	public float rightBoundary;
	public float leftBoundary;
	public bool faint;
	void Start () {
		faint = true;
		myRigidbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		gm = GameObject.FindGameObjectWithTag ("GameManager2").GetComponent<gameManager2> ();
		anim.Play ("faint");
		Invoke ("DisableFaint", 5f);
		movementSpeed = 4;

	}
	void FixedUpdate(){

		float horizontal = Input.GetAxis("Horizontal");
		handleMovement(horizontal);
		Flip (horizontal);


	}

	void Update(){
		if (!faint) {
			Vector3 pos = transform.position;
			if (pos.x > rightBoundary + Camera.main.orthographicSize) {
				pos.x = rightBoundary + Camera.main.orthographicSize;
			}
			if (pos.x < leftBoundary + Camera.main.orthographicSize) {
				pos.x = leftBoundary + Camera.main.orthographicSize;
			}
			transform.position = pos;
		}
	}

	private void handleMovement(float horizontal){
		if (!faint) {
			myRigidbody.velocity = new Vector2 (horizontal * movementSpeed, myRigidbody.velocity.y);
			anim.SetFloat ("speed", Mathf.Abs (horizontal));
		}
	}

	private void Flip(float horizontal){
		if (!faint) {
			if (horizontal > 0 && facingLeft || horizontal < 0 && !facingLeft) {
				facingLeft = !facingLeft;
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;
			}
		}
	}
	void DisableFaint(){
		anim.Play ("stand");
		faint = false;
	}
}

