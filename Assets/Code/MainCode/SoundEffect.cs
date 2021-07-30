using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SoundEffect : MonoBehaviour 
{
	public AudioClip eat;
	public Toggle T;
	void OnCollisionEnter (Collision collision )
	{
		if (T.isOn)
		{
		 audio.PlayOneShot(eat);
		}
	}
}