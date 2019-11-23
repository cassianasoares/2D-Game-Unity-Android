using System.Collections;
using UnityEngine;

public class TestChanger : MonoBehaviour
{

  public GameObject CyanCircle;
  public GameObject YellowCircle;
  public GameObject MargentaCircle;
  public GameObject PinkCircle;


  private int num = 0;

  void Start()
  {
    StartCoroutine(Test());
  }

  IEnumerator Test()
  {
    while( num < 100)
    {
      SetRandomColor();
      //yield return new WaitForSecondsRealtime(9);
      num += 1;
      yield return new WaitForSeconds(1f);
    }
  }

 void SetRandomColor()
	{
		int index = Random.Range(0, 4);

		switch (index)
		{
			case 0:
				CyanCircle.SetActive(true);
				YellowCircle.SetActive(false);
				MargentaCircle.SetActive(false);
				PinkCircle.SetActive(false);
				break;
			case 1:
				CyanCircle.SetActive(false);
				YellowCircle.SetActive(true);
				MargentaCircle.SetActive(false);
				PinkCircle.SetActive(false);
				break;
			case 2:
				CyanCircle.SetActive(false);
				YellowCircle.SetActive(false);
				MargentaCircle.SetActive(true);
				PinkCircle.SetActive(false);
				break;
			case 3:
				CyanCircle.SetActive(false);
				YellowCircle.SetActive(false);
				MargentaCircle.SetActive(false);
				PinkCircle.SetActive(true);
				break;
		}
	}
}
