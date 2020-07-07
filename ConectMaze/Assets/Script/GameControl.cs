using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    [SerializeField]
    private Transform[] pictures;

    private int pieces = 0;

    [SerializeField]
   private GameObject winText;

    public static bool youWin;

    public Animator transitionAnim;
    public float transitionTime = 1f;

    public Text changingText;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
        changingText.text = (SceneManager.GetActiveScene().buildIndex).ToString();
    }

    // Update is called once per frame
    void Update()
    {
            if(pictures.Length == 4){
                checkedFour();
            }else if(pictures.Length == 6){
                checkedSix();
            }else if(pictures.Length == 9){
                checkedNine();
            }else if(pictures.Length == 12){
                checkedTwelve();
            }else if(pictures.Length == 16){
                checkedSixTeen();
            }else if(pictures.Length == 20){
                checkedTwenty();
            }

    }


    private void checkedFour()
    {
        if(pictures[0].rotation.z == 0 &&
        pictures[1].rotation.z == 0 &&
        pictures[2].rotation.z == 0 &&
        pictures[3].rotation.z == 0 )
        {
            winText.SetActive(true);
            youWin = true;
            LoadNextLevel();
        }
    }

    private void checkedSix()
    {
        if(pictures[0].rotation.z == 0 &&
        pictures[1].rotation.z == 0 &&
        pictures[2].rotation.z == 0 &&
        pictures[3].rotation.z == 0 &&
        pictures[4].rotation.z == 0 &&
        pictures[5].rotation.z == 0 )
        {
            winText.SetActive(true);
            youWin = true;
            LoadNextLevel();
        }
    }

    private void checkedNine()
    {
        if(pictures[0].rotation.z == 0 &&
        pictures[1].rotation.z == 0 &&
        pictures[2].rotation.z == 0 &&
        pictures[3].rotation.z == 0 &&
        pictures[4].rotation.z == 0&&
        pictures[5].rotation.z == 0 &&
        pictures[6].rotation.z == 0 &&
        pictures[7].rotation.z == 0 &&
        pictures[8].rotation.z == 0 )
        {
            winText.SetActive(true);
            youWin = true;
            LoadNextLevel();
        }
    }

    private void checkedTwelve()
    {
        if(pictures[0].rotation.z == 0 &&
        pictures[1].rotation.z == 0 &&
        pictures[2].rotation.z == 0 &&
        pictures[3].rotation.z == 0 &&
        pictures[4].rotation.z == 0&&
        pictures[5].rotation.z == 0 &&
        pictures[6].rotation.z == 0 &&
        pictures[7].rotation.z == 0 &&
        pictures[8].rotation.z == 0 &&
        pictures[9].rotation.z == 0 &&
        pictures[10].rotation.z == 0 &&
        pictures[11].rotation.z == 0)
        {
            winText.SetActive(true);
            youWin = true;
            LoadNextLevel();
        }
    }

    private void checkedSixTeen()
    {
        if(pictures[0].rotation.z == 0 &&
        pictures[1].rotation.z == 0 &&
        pictures[2].rotation.z == 0 &&
        pictures[3].rotation.z == 0 &&
        pictures[4].rotation.z == 0&&
        pictures[5].rotation.z == 0 &&
        pictures[6].rotation.z == 0 &&
        pictures[7].rotation.z == 0 &&
        pictures[8].rotation.z == 0 &&
        pictures[9].rotation.z == 0 &&
        pictures[10].rotation.z == 0 &&
        pictures[11].rotation.z == 0 &&
        pictures[12].rotation.z == 0 &&
        pictures[13].rotation.z == 0 &&
        pictures[14].rotation.z == 0 &&
        pictures[15].rotation.z == 0)
        {
            winText.SetActive(true);
            youWin = true;
            LoadNextLevel();
        }
    }

    private void checkedTwenty()
    {
        if(pictures[0].rotation.z == 0 &&
        pictures[1].rotation.z == 0 &&
        pictures[2].rotation.z == 0 &&
        pictures[3].rotation.z == 0 &&
        pictures[4].rotation.z == 0&&
        pictures[5].rotation.z == 0 &&
        pictures[6].rotation.z == 0 &&
        pictures[7].rotation.z == 0 &&
        pictures[8].rotation.z == 0 &&
        pictures[9].rotation.z == 0 &&
        pictures[10].rotation.z == 0 &&
        pictures[11].rotation.z == 0 &&
        pictures[12].rotation.z == 0&&
        pictures[13].rotation.z == 0 &&
        pictures[14].rotation.z == 0 &&
        pictures[15].rotation.z == 0 &&
        pictures[16].rotation.z == 0 &&
        pictures[17].rotation.z == 0 &&
        pictures[18].rotation.z == 0 &&
        pictures[19].rotation.z == 0)
        {
            winText.SetActive(true);
            youWin = true;
            LoadNextLevel();
        }
    }

    
    public void LoadNextLevel()
    {
         StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transitionAnim.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }


}
