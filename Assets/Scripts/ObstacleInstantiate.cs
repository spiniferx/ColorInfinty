using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInstantiate : MonoBehaviour {

	// Use this for initialization
	public GameObject[] obstacle;
	public void Producer1()
	{
		//Debug.Log ("Obstacles");
		int i = Random.Range (0,obstacle.Length);
		Instantiate (obstacle[i], new Vector3 (obstacle[i].transform.position.x+8.0f, transform.position.y+3f, obstacle[i].transform.position.z),Quaternion.identity);
	}
}
