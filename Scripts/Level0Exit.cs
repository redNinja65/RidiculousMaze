using UnityEngine;
using System.Collections;

public class Level0Exit : MonoBehaviour {


	void fadingloadingscreen()
	{
		float fadeTime = GameObject.Find ("Rear BackGround").GetComponent<Fading> ().BeginFade (1);
		Invoke ("loadnextlevel", fadeTime);
		
	}
	void loadnextlevel()
	{
		Application.Quit ();

	}

}