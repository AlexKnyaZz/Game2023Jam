using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObjectsScript : MonoBehaviour
{
    public GameObject setAct;
    public GameObject setFal;

    public void OnMouseDown()
    {
        setAct.SetActive(true);
        setFal.SetActive(false);
    }

}
