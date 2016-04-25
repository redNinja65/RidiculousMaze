using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class wincollisionpole : MonoBehaviour {

	
	public static wincollisionpole instance = null;

	public static bool isgamewon;
	public Text winningNote;


	void Awake()
	{ 
		if (instance == null)	//checking that we have a game manager or not,if null then instance(GM) here,become this..that is now it is,
			instance = this;
		else if (instance != this)//if there is any other game manager then destroy that game manager,gameobject
			Destroy (gameObject);
	}

	
	void Update() {

		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(transform.position, fwd, 0.4f))  
		{
			midmenubuttons.instance.multiplieractive=true;
			isgamewon=true;
			float fadeTime = GameObject.Find ("Game Manager").GetComponent<Fading> ().BeginFade (1);
			Invoke ("loadnextlevel", fadeTime);

			
		}
			
		}
		
	void loadnextlevel()
	{
		Application.LoadLevel ("LoadingScreen");
	}

	}
	
	
	
	
	
	
	
	
	

