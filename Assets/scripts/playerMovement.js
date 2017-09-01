#pragma strict
var moveSpeed : float = 5;
var anim:Animator;
var facingLeft:boolean;
var horizontal=Input.GetAxis("Horizontal");

 

function Start () {
       anim = gameObject.GetComponent("Animator"); //Get Animations for character
       facingLeft=true;
}  
 
function Update () {
		
        anim.SetFloat("moveSpeed",Mathf.Abs(Input.GetAxis("Horizontal")));
        transform.position.x+=Input.GetAxis("Horizontal")*moveSpeed*Time.deltaTime;
        if(horizontal>0&& facingLeft || horizontal<0 &&!facingLeft){
        	
        	Flip();
        }


}

function Flip()
 {
     facingLeft = !facingLeft;
     var theScale = transform.localScale;
     theScale.x *= -1;
     transform.localScale = theScale;
 }

