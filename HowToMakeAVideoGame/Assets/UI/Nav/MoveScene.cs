using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScene : MonoBehaviour {

	public void Move(string sceneName)
	{
		Application.LoadLevel(sceneName);
	}
}
