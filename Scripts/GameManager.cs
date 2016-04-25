using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//public Player secondaryPlayer;

	//private Player secondaryPlayerinstance;
	int i;
	public Maze mazePrefab;

	public GameObject pole;

	public Player playerPrefab;

	private Maze mazeInstance;

	private static Player playerInstance;

	private void Start () {
		i = Random.Range (0, 2);
		BeginGame();
	}
	
//	public void Update () {
//			
//				if ((midmenubuttons.instance.gameover.isActiveAndEnabled)) 
//		{
//			Application.LoadLevel("LosingScene");
//		}
//
//	}

	private void BeginGame () {

		mazeInstance = Instantiate (mazePrefab) as Maze;
		mazeInstance.Generate ();


		if(midmenubuttons.easybool==true && i==0)
		{
		 	Instantiate(pole, new Vector3(-9.5f, 0f, -3.5f), Quaternion.Euler(0, 0, 0));
			//Instantiate(pole, new Vector3(0f, 0f, 0f), Quaternion.Euler(0, 0, 0));
		}
		else if(midmenubuttons.easybool==true && i==1)
		{
			Instantiate(pole, new Vector3(-4.5f, 0f, -4.5f), Quaternion.Euler(0, 0, 0));
		}
		else if(midmenubuttons.profbool==true && i==0)
		{
			Instantiate(pole, new Vector3(6.5f, 0f, -3.5f ), Quaternion.Euler(0, 0, 0));
		}
		else if(midmenubuttons.profbool==true && i==1)
		{
			Instantiate(pole, new Vector3(5.5f, 0f, -8.5f ), Quaternion.Euler(0, 0, 0));
		}
		else if(midmenubuttons.worldbool==true && i==0)
		{
			Instantiate(pole, new Vector3(8.5f, 0f, -7.5f), Quaternion.Euler(0, 0, 0));
		}
		else if(midmenubuttons.worldbool==true && i==1)
		{
			Instantiate(pole, new Vector3(7.5f, 0f, -9.5f), Quaternion.Euler(0, 0, 0));
		}
		else if(midmenubuttons.legendbool==true && i==0)
		{
			Instantiate(pole, new Vector3(9.5f, 0f, -9.5f), Quaternion.Euler(0, 0, 0));
		}
		else if(midmenubuttons.legendbool==true && i==1)
		{
			Instantiate(pole, new Vector3(9.5f, 0f, -9.5f), Quaternion.Euler(0, 0, 0));
		}



		
		

		
		IntVector2 coordinaterandomly = mazeInstance.RandomCoordinates;

		playerInstance = Instantiate (playerPrefab) as Player;
		playerInstance.SetLocation (mazeInstance.GetCell (coordinaterandomly));



	}
}

//		secondaryPlayerinstance = Instantiate(secondaryPlayer) as Player;
//		secondaryPlayerinstance.SetLocation(mazeInstance.GetCell(coordinaterandomly));





//	void FixedUpdate()
//	{
//		if (camerarotationwithwholeview.instance.sizekittenincreaser == false) {
//			transform.localScale = new Vector3 (2, 2, 2);
//			Debug.Log ("size normalcamerarotationwithwholeview.instance.sizekittenincreaser");
//		} else if (camerarotationwithwholeview.instance.sizekittenincreaser == true) {
//			transform.localScale = new Vector3 (7, 7, 7);
//			Debug.Log ("size big,camerarotationwithwholeview.instance.sizekittenincreaser");
//			
//		}
//	}
	

//	private void RestartGame () {
//		Destroy(mazeInstance.gameObject);
//		if (playerInstance != null) {
//			Destroy(playerInstance.gameObject);
//		}
//		BeginGame();
//	}