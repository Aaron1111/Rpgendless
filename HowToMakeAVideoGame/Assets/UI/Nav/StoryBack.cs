using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryBack : MonoBehaviour {
	public GameObject panel1;
	public GameObject panel2;
	private int counter=0;

	public void showhidePanel()
	{
		counter++;
		if(counter%1==0)
		{
			panel1.gameObject.SetActive(false);
			panel2.gameObject.SetActive(true);
		}
		else
		{
			panel1.gameObject.SetActive(true);
			panel2.gameObject.SetActive(false);
		}
	}
	
}
