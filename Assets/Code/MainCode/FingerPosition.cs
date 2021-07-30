using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class FingerPosition : MonoBehaviour 
{
	public Text txt;
	public Collider cube;
	//private GameObject obj=null;
	private string touchstr ;
	private float Xposition;
	private float xRast;
	private float xChap;
	void Start () 
	{
	cube.transform.position= new Vector3(220,-182,-2);
	}
	void Update () 
	{
		if(Time.timeScale==1)
		{
		xRast=cube.transform.position.x+70;
		xChap=cube.transform.position.x-70;
			if(Input.touchCount>0)
			 if (Input.GetTouch (0).position.y<45 && Input.GetTouch (0).position.x>xChap && Input.GetTouch (0).position.x<xRast)
		      if (Input.GetTouch (0).phase == TouchPhase.Moved)
		      {
			  float Xposition = Input.GetTouch(0).position.x;
			  cube.transform.position = new Vector3(Xposition,-182,-2);
		      } 
		}
	}

}

