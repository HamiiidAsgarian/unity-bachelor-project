using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Pause : MonoBehaviour 
{
	public Button butt;
	public Sprite im1;
	public Sprite im2;
	void Update () 
	{
		if(Time.timeScale ==0) 
		{
		 butt.image.overrideSprite=im1;
		}
		if(Time.timeScale ==1) 
		{
		 butt.image.overrideSprite=im2;
		}
	}
}
