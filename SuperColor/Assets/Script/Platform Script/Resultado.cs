using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Resultado : MonoBehaviour
{
    public int idLevel;
    public int totalLevel;
    private int habilita;
    public int pontoMaximoSalvo;
    public Text txtCompletou;
    public Text txtPontosTotal;

    private int completou;
    private int recorde;

    public Button btnNext;


    void Start(){
      idLevel = PlayerPrefs.GetInt("IdLevel");
      recorde = PlayerPrefs.GetInt("PontuacaoAtualL");
      btnNext.interactable = false;
      completou = PlayerPrefs.GetInt("Complet");
      Pontuacao();
      txtPontosTotal.text = PlayerPrefs.GetInt("PontuacaoTotal").ToString();
      SetSituacao();
    }

    void SetSituacao(){
      habilita = idLevel + 1;
      if(completou ==  0){
        txtCompletou.text = "FAIL";
      }else if(completou == 1){
        txtCompletou.text = "Completo";
        if(habilita <= totalLevel){
          btnNext.interactable = true;
        }else{
          btnNext.interactable = false;
        }
      }
    }

    void Pontuacao(){
      if(recorde > 0){
        pontoMaximoSalvo += recorde;
        PlayerPrefs.SetInt("PontuacaoTotal", pontoMaximoSalvo);
      }
    }


}
