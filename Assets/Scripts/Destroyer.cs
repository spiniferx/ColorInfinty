using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {


	void Start()
	{
		//DestroyObjectDelayed ();
	}

	/*void DestroyObjectDelayed()
	{
		// Kills the game object in 5 seconds after loading the object
		Destroy(gameObject, 30);
	}*/
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "enemy" || col.gameObject.tag == "Player") {
			Debug.Log ("Collide hua");
			Destroy (col.gameObject);
		}

	}
}
