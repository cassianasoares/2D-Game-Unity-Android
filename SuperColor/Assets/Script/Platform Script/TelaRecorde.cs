using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelaRecorde : MonoBehaviour
{
    public Text txtPontosTotal;
    public int recorde;
    public int total= 0;



    void Start()
    {
        recorde = PlayerPrefs.GetInt("PontuacaoTotal");
        txtPontosTotal.text = recorde.ToString();
    }


    public void ZerarPontos(){
      PlayerPrefs.DeleteAll();
    }


}
