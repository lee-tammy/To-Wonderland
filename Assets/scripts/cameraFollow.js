#pragma strict

var target : Transform;
var distance : float = 3.0;
var height : float = 3.0;
var width : float = 3.0;
var damping : float = 5.0;
var boundaryLeft :float;
var boundaryRight:float;

function Update () {
var wantedPosition : Vector3 = target.TransformPoint(width,height, -distance);
transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.deltaTime * damping);

if(transform.position.x <boundaryLeft){
	transform.position=new Vector3(boundaryLeft,transform.position.y, transform.position.z);
}else if(transform.position.x>boundaryRight){
	transform.position=new Vector3(boundaryRight,transform.position.y, transform.position.z);
}
}