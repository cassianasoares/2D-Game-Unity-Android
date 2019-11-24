using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class temaJogo : MonoBehaviour
{

    public Button btnLevel;
    private int idLevel;
    private int nextlevel;
    public int totalLevels;


    public void qualLevel(int id){
      idLevel = id;
    }

    public void jogar(){
      Application.LoadLevel("L"+idLevel.ToString());
    }


}
