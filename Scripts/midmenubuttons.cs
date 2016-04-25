using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class midmenubuttons : MonoBehaviour {


	public static midmenubuttons instance = null;

	public static bool easybool;
	public bool multiplieractive;
	public static bool profbool;
	public static bool worldbool;
	public static bool legendbool;
	public static float timeRemaining; 
	public static float multiplierasdifficulty; 
	public static float ratingvalue; 
	//public Button Restart;
	public Text gameover;
	public Text TimerText;
	public Text winningNote;
	float minutes;
	float seconds;



	void Awake()
	{ 
		if (instance == null)	//checking that we have a game manager or not,if null then instance(GM) here,become this..that is now it is,
			instance = this;
		else if (instance != this)//if there is any other game manager then destroy that game manager,gameobject
			Destroy (gameObject);


		DontDestroyOnLoad (TimerText);
//		DontDestroyOnLoad (Restart);
		DontDestroyOnLoad (gameover);
//		DontDestroyOnLoad (Rating);

	}

	void Update()
	{
		timeRemaining -= Time.deltaTime;
		if (timeRemaining > 0 )
		{
		//	gameover.gameObject.SetActive(false);
			//Restart.gameObject.SetActive(false);
			float minutes = Mathf.Floor(timeRemaining / 60);
			float seconds = Mathf.Floor(timeRemaining % 60);
			TimerText.text = " " + minutes.ToString("00") + ":" + seconds.ToString("00");
		}
		if ((int)timeRemaining == 0 )
		{
			float fadeTime = GameObject.Find ("Game Manager").GetComponent<Fading> ().BeginFade (1);
			Invoke ("loadlosinglevel", fadeTime);

			//gameover.gameObject.SetActive(true);
//			Restart.gameObject.SetActive(true);

		}

	}

	public void easylevel()
	{

		easybool = true;
		timeRemaining = 151f;
		fadingloadingscreen ();

	}
	public void proflevel()
	{

		profbool = true;
		timeRemaining =91f;
		fadingloadingscreen ();
	}
	public void worldclasslevel()
	{
		worldbool = true;
		timeRemaining = 121f;
		fadingloadingscreen ();
	}
	public void legenderylevel()
	{
		legendbool = true;
		timeRemaining = 80f;
		fadingloadingscreen ();

	}


void fadingloadingscreen()
{
		float fadeTime = GameObject.Find ("Main Camera").GetComponent<Fading> ().BeginFade (1);
		Invoke ("loadnextlevel", 1f);

}
	void loadnextlevel()
	{
		Application.LoadLevel ("Level1");
	}
	void loadlosinglevel()
	{
		Application.LoadLevel ("LosingScreen");
	}
}