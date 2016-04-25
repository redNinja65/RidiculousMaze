using UnityEngine;
using System.Collections;

public class Levelloader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("scene1loading", 2f);	
	}

	void scene1loading()
	{
		Application.LoadLevel ("Level1");
	}
	
}
