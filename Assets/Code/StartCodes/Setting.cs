using UnityEngine;
using System.Collections;
public class Setting : MonoBehaviour 
{
	public GameObject setting;
    int settTogg=0;
	public void SettingToggle ()
	{
		if (settTogg == 0)
		{
		 setting.SetActive (true);
		 settTogg=1;
		} 
		else
		{
		 setting.SetActive (false);
		 settTogg=0;
		}

	}
}
