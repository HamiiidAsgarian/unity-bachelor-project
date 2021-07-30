using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Meneu : MonoBehaviour 
{
	public Button Exit;
	public GameObject Pan;
	public Slider slid;
	public AudioSource sound;
 void Update ()
 {
 if (Time.timeScale == 0) 
		{
         Pan.SetActive (true);
		}
		else
		{
			Pan.SetActive(false);
		}
 sound.volume=slid.value;
 }
}
