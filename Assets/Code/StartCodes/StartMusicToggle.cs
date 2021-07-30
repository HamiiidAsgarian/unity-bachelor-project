using UnityEngine;
using System.Collections;

public class StartMusicToggle : MonoBehaviour {
	//public AudioSource Sound;
	public GameObject go;
	int IsOn=1;
	public void SoundPlay ()
	{
		if (IsOn == 1) 
		{
		//Sound.volume = 0;
			IsOn=0;
		go.SetActive(false);
		
		}
		else if(IsOn == 0) 
		{
			IsOn=1;
			//Sound.volume = 1f;
			go.SetActive(true);

		}
	}
}
