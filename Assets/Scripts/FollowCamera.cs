using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	public Transform player;

	public ColorChangerInstantiate cci;
	public ObstacleInstantiate oi;

	public Transform other;
	public Transform InsideCamera;

	public ScoreScript ss;

	// Use this for initialization
	// Update is called once per frame
	void Update () {

		float dist = Vector3.Distance(other.position, InsideCamera.position);

		if (player.position.y > transform.position.y) {
			//Debug.Log("Distance to other: " + dist);

			if(dist>=7)
			{
				dist = 0;
				ss.UpdateScorr ();
				other.position = new Vector3 (other.position.x, InsideCamera.position.y,other.position.z);
			   cci.Producer ();
			   oi.Producer1 ();


			}
			transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
		
		}

	}
}
