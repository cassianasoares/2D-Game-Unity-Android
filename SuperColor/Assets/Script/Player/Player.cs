using UnityEngine;
using UnityEngine.UI;
﻿using UnityEngine.SceneManagement;
using System.Collections;

public class Player : MonoBehaviour
{

  	public float jumpForce = 5f;
  	private int num = 0;

  	public Rigidbody2D rb;
  	public SpriteRenderer sr;

    public int pontosTemp;
    public Text txtPontos;

  	public string currentColor;
    private int faseFull;

  	public Color colorCyan;
  	public Color colorYellow;
  	public Color colorMargenta;
  	public Color colorPink;
    //private bool inicio;


  	void Start (){
      rb.isKinematic = true;
      pontosTemp=0;
      txtPontos.text = "0";
  		SetRandomColor();
  	}

  	// Update is called once per frame
  	void Update () {

  		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
  		{
        rb.isKinematic = false;
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

      if(col.tag == "Estrela"){
  			SetPontos();
      /*  if(pontosTemp > 0){
          pontos++;
          Debug.Log (pontos);*/
          //PlayerPrefs.SetInt("PontuacaoT", pontos);

  			Destroy(col.gameObject);
  			return;
  		}

      if(col.tag == "FixaFinal"){
        CompletouFase();
        return;
  		}

  		if(col.tag != currentColor){
        NotCompletouFase();
        return;
  			//Debug.Log ("GAME OVER");
  			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  		}
  	}


    void SetPontos(){
      pontosTemp ++;
      PlayerPrefs.SetInt("PontuacaoAtualL", pontosTemp);
      txtPontos.text = pontosTemp.ToString();
    }

    void NotCompletouFase(){
      faseFull = 0;
      PlayerPrefs.SetInt("Complet", faseFull);
      Application.LoadLevel("Pontuacao");
    }

    void CompletouFase(){
      faseFull = 1;
      PlayerPrefs.SetInt("Complet", faseFull);
      Application.LoadLevel("Pontuacao");
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
