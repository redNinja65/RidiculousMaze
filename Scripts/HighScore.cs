using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {

	public Text EasyHigh;
	public Button Highscorebutton;
	public Text ProfHigh;
	public Text WorldHigh;
	public Text LegendHigh;
	

	

	void Update () {

		int oldHighscoreE  = PlayerPrefs.GetInt("highscoreE");
		int oldHighscoreP = PlayerPrefs.GetInt ("highscoreP");
		int oldHighscoreW = PlayerPrefs.GetInt ("highscoreW");
		int oldHighscoreL = PlayerPrefs.GetInt ("highscoreL");

	

			if ((int)midmenubuttons.ratingvalue > oldHighscoreE) {
			if (midmenubuttons.easybool == true) {

				PlayerPrefs.SetInt ("highscoreE", (int)midmenubuttons.ratingvalue);
				//EasyHigh.gameObject.SetActive (false);

				midmenubuttons.easybool = false;
			}
		}
			if((int)midmenubuttons.ratingvalue > oldHighscoreP)
			{
			if (midmenubuttons.profbool == true) {
				
				PlayerPrefs.SetInt ("highscoreP", (int)midmenubuttons.ratingvalue);
				//EasyHigh.gameObject.SetActive (false);
				midmenubuttons.profbool=false;
			}
		}
			
		if((int)midmenubuttons.ratingvalue > oldHighscoreW)
			{
			if (midmenubuttons.worldbool == true) {
				
				PlayerPrefs.SetInt ("highscoreW", (int)midmenubuttons.ratingvalue);
				//EasyHigh.gameObject.SetActive (false);
				midmenubuttons.worldbool=false;
			}
		}
			if( (int)midmenubuttons.ratingvalue > oldHighscoreL)
			{
			if (midmenubuttons.legendbool == true) {
				
				PlayerPrefs.SetInt ("highscoreL", (int)midmenubuttons.ratingvalue);
				//EasyHigh.gameObject.SetActive (false);
				midmenubuttons.legendbool=false;
			}
		}
		







	//	highscore.gameObject.SetActive (true);
	//	highscore.text = "Best: " + PlayerPrefs.GetInt("highscore");

	}

	public void onclickhighscore()
	{
	 
			EasyHigh.text = "EASY: " + PlayerPrefs.GetInt ("highscoreE");
			ProfHigh.text = "PROFESSIONAL: " + PlayerPrefs.GetInt ("highscoreP");
			WorldHigh.text = "WORLDCLASS: " + PlayerPrefs.GetInt ("highscoreW");
			LegendHigh.text = "LEGENDERY: " + PlayerPrefs.GetInt ("highscoreL");
			Highscorebutton.gameObject.SetActive (false);
			EasyHigh.gameObject.SetActive (true);
			ProfHigh.gameObject.SetActive (true);
			WorldHigh.gameObject.SetActive (true);
			LegendHigh.gameObject.SetActive (true);


	}



}
