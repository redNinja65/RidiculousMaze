using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class camerarotationwithwholeview : MonoBehaviour {
	

	public static camerarotationwithwholeview instance = null;
	public bool makemeappear50 = false;
	public Camera cameraSecond;
	public Text BackToGame;
	public Text timerdecreaser;
	public Text timerdecreaserincrement;
	public Text GoToHint;
	public Maze target;//the target object
	private float speedMod = 10.0f;//a speed modifier
	private Vector3 point;//the coord to the point where the camera looks at



	void Awake()
	{ 
		if (instance == null)	//checking that we have a game manager or not,if null then instance(GM) here,become this..that is now it is,
			instance = this;
		else if (instance != this)//if there is any other game manager then destroy that game manager,gameobject
			Destroy (gameObject);
	}

	void Start () 
	{
		//Set up things on the start method
		point = target.transform.position;//get target's coords
		transform.LookAt (point);//makes the camera look to it
	}
	

	void Update () {//makes the camera rotate around "point" coords, rotating around its Y axis, 20 degrees per second times the speed modifier
		if ((midmenubuttons.worldbool == true) || (midmenubuttons.legendbool == true)) {
			transform.RotateAround (point, new Vector3 (0.0f, 1.0f, 0.0f), 1 * Time.deltaTime * speedMod);
		}
		if (GoToHint.isActiveAndEnabled) {
			BackToGame.enabled = false;
		}
	
		if (timerdecrease.makemerun == true) {
			Invoke ("MainCameraActive", 0f);
		}

		if (timerdecreasesecond.makemerunincrement == true) {
			GoToHint.enabled = true;
			timerdecreaserincrement.gameObject.SetActive(false);
			timerdecreasesecond.makemerunincrement =false;

		}
	}


	public void CameraActive()
	{
		Camera.main.depth = -2;
		BackToGame.enabled = true;
		GoToHint.enabled = false;
		timerdecreasesecond.timeRemainingincamerachangesecond = 51;
		timerdecreaser.gameObject.SetActive(true);
		timerdecreaserincrement.gameObject.SetActive (false);

	
		//sizekittenincreaser = true;
	}
	public void onclickbacktofun()
	{
		Camera.main.depth = 0;
		BackToGame.enabled = false;
		timerdecrease.makemerun = false;
		GoToHint.enabled = true;
		timerdecreaser.gameObject.SetActive(false);

	}

	public void MainCameraActive()
	{
		Debug.Log (timerdecreasesecond.makemerunincrement);
		Camera.main.depth = 0;
		makemeappear50 = true;
		timerdecrease.timeRemainingincamerachange = 21;
		timerdecreaserincrement.gameObject.SetActive (true);
		timerdecreaser.gameObject.SetActive (false);
		BackToGame.enabled = false;
		timerdecrease.makemerun = false;
//		if (timerdecrease.makemerun == false) {
//			GoToHint.enabled = true;
//		}


		//sizekittenincreaser = false;
	}

}