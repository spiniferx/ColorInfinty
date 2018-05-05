using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	// Use this for initialization
   
	bool check;
	bool audiocheck;
	void Start () {
		check = false;
		audiocheck = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void home()
	{
		SceneManager.LoadScene ("Menu");
	}
	public void retry ()
	{
		SceneManager.LoadScene("Level1");
	}
	public void play()
	{
		SceneManager.LoadScene ("Level1");
	}
	public void sound()
	{
		if (!audiocheck) {
			AudioListener.pause = true;
			audiocheck = true;
		} else {
			AudioListener.pause = false;
			audiocheck = false;
		}
	}
	public void Exit()
	{
		Application.Quit ();
	}
	public void Pause()
	{
		
		if (!check) {
			Time.timeScale = 0f;
			check = true;
		} else {
			Time.timeScale = 1f;
			check = false;
		}
	}
		



}
