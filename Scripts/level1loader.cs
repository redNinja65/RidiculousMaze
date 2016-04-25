using UnityEngine;
using System.Collections;

public class level1loader : MonoBehaviour {

	// Use this for initialization
//	void Start () {
//	
//		Invoke ("LEVEL1LOADER", 2f);
//	}

	void fadingloadingscreen()
	{
		float fadeTime = GameObject.Find ("Game Manager").GetComponent<Fading> ().BeginFade (1);
		Invoke ("loadnextlevel", fadeTime);
		
	}
	void loadnextlevel()
	{
		Application.LoadLevel ("Level1");
	}
	

	
//	void LEVEL1LOADER()
//	{
//		Application.LoadLevel ("Level1");
//	}
}
