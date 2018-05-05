using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	// Use this for initialization
	public int scoreValue=0;
	public Text score;

	void Start () {
		score = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	public void UpdateScorr () {
		scoreValue += 1;
		score.text ="Score: " + scoreValue;
	}
}
