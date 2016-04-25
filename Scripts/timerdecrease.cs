using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timerdecrease : MonoBehaviour {

	float seconds;
	public static bool makemerun=false;
	public static float timeRemainingincamerachange=21;
	public Text timerforcamerachange;


	void Update()
	{
		timeRemainingincamerachange -= Time.deltaTime;
		if (timeRemainingincamerachange >= 0) {
			makemerun=false;
		 	seconds = Mathf.Floor (timeRemainingincamerachange % 60);
			timerforcamerachange.text = seconds.ToString ("00");
		}
		 if((int)seconds==0){
			 makemerun = true;
		}


	}






}