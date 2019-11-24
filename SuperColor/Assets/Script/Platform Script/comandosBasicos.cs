using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandosBasicos : MonoBehaviour
{
  public int idlevel;
  private int nextlevel;

  void Start(){
    idlevel = PlayerPrefs.GetInt("IdLevel");
    nextlevel = idlevel + 1;
  }

  public void carregaCena(string nomeCena)
  {
    Application.LoadLevel(nomeCena);
  }

  public void carregaNextCena()
  {
    Application.LoadLevel("L"+nextlevel.ToString());
  }

  public void carregaRepetir()
  {
    Application.LoadLevel("L"+idlevel.ToString());
  }

}
