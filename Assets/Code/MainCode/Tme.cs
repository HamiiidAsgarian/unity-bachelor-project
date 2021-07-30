using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Tme : MonoBehaviour 
{
	public Text TimeTXT;
	string tim;
	void Update () 
	{
	 tim = Time.timeSinceLevelLoad.ToString("F1");
	 TimeTXT.text ="Time: "+tim;
	}
}
