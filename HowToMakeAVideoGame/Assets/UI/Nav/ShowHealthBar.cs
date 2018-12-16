using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHealthBar : MonoBehaviour {
	public GameObject panel1;
	public GameObject panel2;
	private int counter=0;

	public void showhidePanel()
	{
			panel1.gameObject.SetActive(false);
	}
	
}
