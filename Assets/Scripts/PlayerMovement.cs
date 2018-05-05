using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

	public float jumpForce;
	public Rigidbody2D myRigidBody;

	public string currentColor;

	public SpriteRenderer sr;

	public Color colorPink;
	public Color colorVoilet;
	public Color colorCyan;
	public Color colorYellow;
	public bool startUp;
	public Text tapstart;
	public Canvas GameOver;
	void Start()
	{
		setRandomColor ();
		startUp = false;
		Time.timeScale = 0.0f;
		tapstart.enabled = true;
		GameOver.enabled = false;

	}

	// Update is called once per frame
	void Update () {

		if (!startUp && Input.GetMouseButton (0)) {
			startUp = true;
			Time.timeScale = 1.0f;
			tapstart.enabled = false;
		}

		if (startUp && Input.GetMouseButton (0)) {
		
			myRigidBody.velocity = Vector2.up * jumpForce;  
		
		}
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "ColorChanger") {
		
			setRandomColor ();
			Destroy (col.gameObject);
			return;
		}

		if (col.tag != currentColor) {
		
			Destroy (gameObject);
			GameOver.enabled = true;
			//Application.LoadLevel ("Level1");
		
		}

	}


	void setRandomColor()
	{
		int index = Random.Range(0,4);

		switch(index)
		{
		case 0:
			currentColor = "cyan";
			sr.color = colorCyan;
			break;
		case 1:
			currentColor = "yellow";
			sr.color = colorYellow;
			break;
		case 2:
			currentColor = "pink";
			sr.color = colorPink;
			break;
		case 3:
			currentColor = "voilet";
			sr.color = colorVoilet;
			break;
		}


	}

}
