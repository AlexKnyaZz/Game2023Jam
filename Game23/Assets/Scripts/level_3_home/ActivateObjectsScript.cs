using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObjectsScript : MonoBehaviour
{
    public GameObject setAct;
    public GameObject setFal;
    public GameObject guitar;


    public void OnMouseDown()
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

}
