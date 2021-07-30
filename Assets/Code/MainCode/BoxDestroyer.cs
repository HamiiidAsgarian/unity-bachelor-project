using UnityEngine;
using System.Collections;

public class BoxDestroyer : MonoBehaviour {
	void OnCollisionEnter (Collision collision )
	{
		if(collision.transform.name == "Hulu(Clone)" )
		{   DestroyFrutes.score=DestroyFrutes.score+3;
			
		}
		if(collision.transform.name == "Sib(Clone)" )
		{   DestroyFrutes.score=DestroyFrutes.score+1;
			
		}
		if(collision.transform.name == "Moz(Clone)" )
		{   DestroyFrutes.score=DestroyFrutes.score+2;
			
		}
		if(collision.transform.name == "Limu(Clone)" )
		{   DestroyFrutes.score=DestroyFrutes.score+1;
			
		}
		if(collision.transform.name == "Bee(Clone)" )
		{   DestroyFrutes.score=DestroyFrutes.score-5;

			
		}

}

}
