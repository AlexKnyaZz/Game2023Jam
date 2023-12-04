using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActivateObjectsScript : MonoBehaviour
{
    public GameObject setAct;
    public GameObject setFal;
    public GameObject guitar;

    public TextMeshProUGUI HomeText2;


    public void OnMouseDown()
    {
        if (GlobalCountsManagerScript.Instance.bedCount != 2)
        {
            if (setFal.activeSelf == true && guitar.CompareTag("guitar"))
            {
            GlobalCountsManagerScript.Instance.guitarCount += 1;   
            setAct.SetActive(true);
            setFal.SetActive(false);
            }
            setAct.SetActive(true);

            if (setFal.activeSelf == true && guitar.CompareTag("tv"))
            {
            GlobalCountsManagerScript.Instance.tvCount += 1;   
            setAct.SetActive(true);
            setFal.SetActive(false);
            }
            setAct.SetActive(true);
        }
        if (gameObject.CompareTag("guitar"))
        {
            if (GlobalCountsManagerScript.Instance.bedCount == 2)
            {
                if (GlobalCountsManagerScript.Instance.guitarCount - GlobalCountsManagerScript.Instance.tvCount == 1)
                {
                    HomeText2.text = "Появилось настроение сыграть на гитаре.";
                    HomeText2.gameObject.SetActive(true);
                }
            }
        }
        if (gameObject.CompareTag("door"))
        {
            if (GlobalCountsManagerScript.Instance.bedCount == 2)
            {
                if ((GlobalCountsManagerScript.Instance.guitarCount - GlobalCountsManagerScript.Instance.tvCount != 1) || (GlobalCountsManagerScript.Instance.tvCount - GlobalCountsManagerScript.Instance.guitarCount == 1))
                {
                    HomeText2.text = "Перед сном надо обязательно покурить...";
                    HomeText2.gameObject.SetActive(true);
                }
            }
        }
    }

}