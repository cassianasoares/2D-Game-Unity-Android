using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{

  public float move_Speed = 2f;
  public float bound_Y = -9f; //altura em que objeto sai da tela

  public bool is_SmallCircle, is_ColorChanger, is_DuoCircle, is_ChangerCircle, is_DuoCicleChanger;

    // Update is called once per frame
    void Update()
    {
      Move();
    }

    void Move(){
      Vector2 temp = transform.position;
      temp.y -= move_Speed * Time.deltaTime;
      transform.position = temp;

      if(temp.y <= bound_Y){
        gameObject.SetActive(false);
      }
    }

}
