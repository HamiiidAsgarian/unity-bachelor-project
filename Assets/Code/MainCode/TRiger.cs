using UnityEngine;
using System.Collections;
public class TRiger : MonoBehaviour 
{
 int pause;
	public void trig ()
 {
	if (pause==1) 
	 {
	  Time.timeScale = 0;
	  pause = 0;
	  goto l1;
	 }
	 if (pause==0) 
	 {
	  Time.timeScale=1;
	  pause=1;
	  goto l1;
	 }
  l1:;
 }	
}
