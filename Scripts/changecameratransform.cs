using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class changecameratransform : MonoBehaviour {


  
	

//
//public GUITexture leftbutton;
//	public GUITexture rightbutton;
//	public GUITexture forwardbutton;
//	public GUITexture backbutton;
//	public Text guitext;
//
//
//	void Awake()
//	{
//
//		leftbutton=GameObject.Find("Left").GetComponent<GUITexture>();
//		rightbutton=GameObject.Find("Right").GetComponent<GUITexture>();
//		forwardbutton=GameObject.Find("Accelrate").GetComponent<GUITexture>();
//		backbutton=GameObject.Find("BackButton").GetComponent<GUITexture>();
//	}


	void Start()
	{	

		Quaternion rotationeasy = Quaternion.Euler (85, 0, 0);
		Quaternion rotationlegend = Quaternion.Euler (45, 0, 0);
		if ((midmenubuttons.easybool == true) || (midmenubuttons.profbool == true)) {

			transform.localPosition = new Vector3 (0f, 19f, -2f);
			transform.localRotation = rotationeasy;
		}
		if ((midmenubuttons.worldbool == true) || (midmenubuttons.legendbool == true)) {
			transform.localPosition = new Vector3 (0f, 11f, -12f);
			transform.localRotation = rotationlegend;
		}
	

	}
//	void FixedUpdate()
//	{
//		if ((camerarotationwithwholeview.instance.guibuttondisable == false) && ((midmenubuttons.profbool == true) || (midmenubuttons.legendbool == true))) {
//			leftbutton.enabled=false;
//			rightbutton.enabled=false;
//			rightbutton.gameObject.AddComponent<Button>().interactable=false;
//			forwardbutton.enabled=false;
//			backbutton.enabled=false;
////			leftbutton.gameObject.SetActive (false);
////			rightbutton.gameObject.SetActive (false);
////			forwardbutton.gameObject.SetActive (false);
////			backbutton.gameObject.SetActive (false);
//			camerarotationwithwholeview.instance.guibuttondisable = true;
//
//
//		} if((camerarotationwithwholeview.instance.guibuttonenabled==true) &&(( (midmenubuttons.profbool == true) || (midmenubuttons.legendbool == true))||(midmenubuttons.easybool == true)||((midmenubuttons.worldbool == true))))
//		{
//			leftbutton.enabled=true;
//			rightbutton.enabled=true;
//			forwardbutton.enabled=true;
//			backbutton.enabled=true;
////			leftbutton.gameObject.SetActive (true);
////			rightbutton.gameObject.SetActive (true);
////			forwardbutton.gameObject.SetActive (true);
////			backbutton.gameObject.SetActive (true);
//			camerarotationwithwholeview.instance.guibuttonenabled = false;
//		}

	}

