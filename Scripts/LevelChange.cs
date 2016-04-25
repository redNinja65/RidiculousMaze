using UnityEngine;
using System.Collections;

public class LevelChange : MonoBehaviour {




	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.CompareTag ("Player")) {

		
			Invoke("NextLevel",1f);
		
		}
	}

	void NextLevel()
	{
		Application.LoadLevel ("Level2");
	}

}

