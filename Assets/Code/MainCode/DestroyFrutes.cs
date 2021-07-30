using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 public class DestroyFrutes : MonoBehaviour 
{
	public static int score=0;
	public Text Te;
	public AudioClip dd;
	public AudioSource DropEffect;
	public GameObject BoxBurden;
	public GameObject BoxBurden2;
	void Start ()
    {
		BoxBurden.SetActive (false);
    }
	void OnCollisionEnter (Collision collision )
	{
		if(collision.transform.name == "Box2" )
		{   
			Destroy (gameObject,0);
			audio.PlayOneShot(dd);
		}
		if(collision.transform.name == "back" )
		{
			Destroy (gameObject,0);
		}
	}
	void Update () 
	{
	Te.text ="score: "+score.ToString();
		if (score < 30) 
		{
			BoxBurden.SetActive(false);
		}
		if (score < 60) 
		{
			BoxBurden2.SetActive(false);
		}

		if (score > 30)

		{
			BoxBurden.SetActive(true);
		}
		if (score > 60)
		{
			BoxBurden2.SetActive(true);
		}
	}
}
