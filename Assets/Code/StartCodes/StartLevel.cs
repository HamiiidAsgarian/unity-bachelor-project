using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StartLevel : MonoBehaviour 
{
	public void StartGame ()
	{
	 Application.LoadLevel(1);
	 DestroyFrutes.score=0;
	 Time.timeScale = 1;	
	}
}