using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {
	public float x;
	void Update () 
	{
		transform.Translate(0,x*Time.deltaTime,0);
	}
}
