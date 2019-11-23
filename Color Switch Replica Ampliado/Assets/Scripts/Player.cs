using UnityEngine;
﻿using UnityEngine.SceneManagement;
using System.Collections;

public class Player : MonoBehaviour {

	public float jumpForce = 5f;
	private int num = 0;

	public Rigidbody2D rb;
	public SpriteRenderer sr;
	private string teste;

	public string currentColor;

	public Color colorCyan;
	public Color colorYellow;
	public Color colorMargenta;
	public Color colorPink;
	public Color colorInvincible;


	void Start (){
		//StartCoroutine(SetColorInvincible());
		SetRandomColor();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			rb.velocity = Vector2.up * jumpForce;
		}

	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "ColorChanger"){
			SetRandomColor();
			Destroy(col.gameObject);
			return;
		}


		if(col.tag != currentColor){

			Debug.Log ("GAME OVER");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	void SetRandomColor ()
	{
		int index = Random.Range(0, 4);

		switch (index)
		{
			case 0:
				currentColor = "Cyan";
				sr.color = colorCyan;
				break;
			case 1:
				currentColor = "Yellow";
				sr.color = colorYellow;
				break;
			case 2:
				currentColor = "Margenta";
				sr.color = colorMargenta;
				break;
			case 3:
				currentColor = "Pink";
				sr.color = colorPink;
				break;
		}
	}

}
