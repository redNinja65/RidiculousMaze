using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level0Enter : MonoBehaviour {

	public Button signout;
	public Button Easy;
	public static int x;
	public Button Professional;
	public Button WorldClass;
	public Button Legendery;
	public Button Startbutton;
	public Button Highscore;
	public Button Watchvideo;
	public Text E;
	public Text P;
	public Text W;
	public Text L;
	public Text UP;
	public Text WP;
	public Text LP;



	public void Start()
	{
		timerdecrease.timeRemainingincamerachange = 21;
		timerdecreasesecond.timeRemainingincamerachangesecond = 51;
	}
	
	public void PlaytheGame() 
	{
		int stateP = PlayerPrefs.GetInt ("Profunlock", 0);
		int stateW = PlayerPrefs.GetInt ("Worldunlock", 0);
		int stateL = PlayerPrefs.GetInt ("Legendunlock", 0);
		if ((midmenubuttons.ratingvalue >= 25) ||(stateP==1) || (firstaddscript.number<=0)) {
			
			Professional.interactable = true;
			PlayerPrefs.SetInt ("Profunlock", 1);
			UP.gameObject.SetActive(false);

		}
		if ((midmenubuttons.ratingvalue >= 288) ||(stateW==2)|| (firstaddscript.number<=0)) {
			
			WorldClass.interactable = true;
			PlayerPrefs.SetInt ("Worldunlock", 2);
			WP.gameObject.SetActive(false);
		
		}
		
		if ((midmenubuttons.ratingvalue >= 726) ||(stateL==3) ||(firstaddscript.number<=0)) {
			
			Legendery.interactable = true;
			PlayerPrefs.SetInt ("Legendunlock", 3);
			x=3;
			LP.gameObject.SetActive(false);

		}
		signout.gameObject.SetActive (false);
		E.gameObject.SetActive (false);
		P.gameObject.SetActive (false);
		W.gameObject.SetActive (false);
		L.gameObject.SetActive (false);
		Easy.gameObject.SetActive(true);
	
		Professional.gameObject.SetActive(true);
		Watchvideo.gameObject.SetActive (false);

		WorldClass.gameObject.SetActive(true);
	
		Legendery.gameObject.SetActive(true);
		Startbutton.gameObject.SetActive (false);
		Highscore.gameObject.SetActive (false);
	//	Application.LoadLevel ("LoadingScreen");
	}

	

}
