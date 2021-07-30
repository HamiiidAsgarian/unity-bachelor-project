using UnityEngine;
using System.Collections;
public class Info : MonoBehaviour 
{
 public GameObject Infor;
 int InfoTogg=0;
 public void InfoToggle ()
 {
   if (InfoTogg == 0)
   {
	Infor.SetActive (true);
	InfoTogg=1;	
	} 
	else
	{
	Infor.SetActive (false);	
	InfoTogg=0;
	}
 }
}