using UnityEngine;
using System.Collections;
public class CreateFrutes1 : MonoBehaviour 
{
	float i=1;
	public Collider Apple;
	public Collider Moze;
	public Collider Limue;
	public Collider Hulu;
	public Collider FlyBizz;

	void Update () 
 {
 float BTWN = Random.Range (0f, 6f);
	if ((Time.time) > i)
	{
	i = Time.time + BTWN;
	int RND=Random.Range(1,19);
		
		if (RND <=15&& RND >= 10)
		{	
		 Instantiate (Apple, new Vector3 (Random.Range(2f,442f), 80f, -0.01f), Quaternion.identity);			
		}
		if (RND <=9&& RND >= 6)
		{
		Instantiate (Limue, new Vector3 (Random.Range(2f,442f), 80f, -0.01f), Quaternion.identity);
		}
		if (RND<= 5 && RND >= 3)
		{
		Instantiate (Moze, new Vector3 (Random.Range(2f,442f), 80f, -0.02f), Quaternion.identity);
		}
		if (RND<= 2 && RND >= 1) 
		{
				Instantiate (Hulu, new Vector3 (Random.Range(2f,442f), 80f, -0.5f), Quaternion.identity);
		}
			if (RND <=19&& RND >= 16)
		{	
				Instantiate (FlyBizz, new Vector3 (Random.Range(2f,442f), 80f, -0.04f), Quaternion.identity);			
		}
		
	}

 }
}
