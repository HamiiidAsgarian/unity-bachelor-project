using UnityEngine;
using System.Collections;
public class Restart : MonoBehaviour 
{
	public void Rstart () 
	{
	 DestroyFrutes.score=0;
	 Application.LoadLevel("Main");
	}
}