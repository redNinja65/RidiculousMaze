using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class testing : MonoBehaviour {

	public Text Ratings;
	//float x;
	// Use this for initialization
	void Start () {

		if (midmenubuttons.easybool == true) {
			midmenubuttons.ratingvalue = midmenubuttons.timeRemaining* 2.5f;
		}
		if (midmenubuttons.profbool == true) {
			midmenubuttons.ratingvalue =  midmenubuttons.timeRemaining * 16f;
		}
		if (midmenubuttons.worldbool == true) {
			midmenubuttons.ratingvalue = midmenubuttons.timeRemaining * 22f;
		}
		if (midmenubuttons.legendbool == true) {
			midmenubuttons.ratingvalue = midmenubuttons.timeRemaining * 30f;
		}
		Ratings.text = "SCORE:" + midmenubuttons.ratingvalue;
		Ratings.gameObject.SetActive (true);

	
	}
	
}
