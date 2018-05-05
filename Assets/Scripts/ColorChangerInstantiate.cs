using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerInstantiate : MonoBehaviour {

	// Use this for initialization
	public GameObject changer;
	public void Producer()
	{
		//Debug.Log ("colorChanger");
		Instantiate (changer, new Vector3 (changer.transform.position.x, transform.position.y+3f, changer.transform.position.z),Quaternion.identity);
	}
}
