using UnityEngine;
using System.Collections;

public class EverPlaysecond : MonoBehaviour {

	public GameObject Everplaybutton;
		void Start () {
		if (!Everyplay.IsRecordingSupported ()) {
			Everplaybutton.gameObject.SetActive (false);
		}

			Everyplay.StopRecording ();
			Debug.Log("Recording stopped");
			
				}
	public void onclickeverplay()
	{
		Debug.Log (midmenubuttons.ratingvalue);
		Everyplay.SetMetadata ("SCORE", midmenubuttons.ratingvalue);
		Everyplay.PlayLastRecording ();

	}
	


	}