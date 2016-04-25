using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timerdecreasesecond : MonoBehaviour {

	

	public static bool makemerunincrement=false;
	float second;
	public static float timeRemainingincamerachangesecond=51;
	public Text timerforcamerachangesecond;





	void Update () {

		if ((camerarotationwithwholeview.instance.makemeappear50 == true) && (timerdecrease.makemerun==false))
		{
			
			timeRemainingincamerachangesecond -= Time.deltaTime;
			if (timeRemainingincamerachangesecond > 0) 
			{
				makemerunincrement=false;
				 second = Mathf.Floor (timeRemainingincamerachangesecond % 60);
				timerforcamerachangesecond.text = second.ToString ("00");
				
				
			}
			if((int)second==0)
			{
				makemerunincrement=true;
			}

	}

}
}
