using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelaJogo : MonoBehaviour
{

    public int idLevel;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("IdLevel", idLevel);
    }

}
