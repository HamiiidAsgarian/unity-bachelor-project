#pragma strict
var BoxSpeed:float=1;
function Update () 
{
 if(Input.GetKey(KeyCode.RightArrow)&& transform.position.x<94f)
 {
 transform.Translate(BoxSpeed*Time.deltaTime,0,0);
 }
 else if(Input.GetKey(KeyCode.LeftArrow)&& transform.position.x>-94)
 {
 transform.Translate(-BoxSpeed*Time.deltaTime,0,0);
 }
}