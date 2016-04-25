using UnityEngine;
using System.Collections;

public class EverPlaymine : MonoBehaviour {

	public Camera camerasecond;

	// Use this for initialization
	void Start () {

//		if(Everyplay.IsRecordingSupported())
//		   {

			if ((camerasecond.enabled==true) && (midmenubuttons.easybool == true) || (midmenubuttons.profbool == true) || (midmenubuttons.worldbool == true) || (midmenubuttons.legendbool == true)) {
			Everyplay.StartRecording ();
			Debug.Log("recording started");
//			}
		}



	}
	

}
