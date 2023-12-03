using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GG : MonoBehaviour
{
    public Event EventScript;

    public Balance BalanceScript;

    public void Run()
    {
        EventScript.CatVstaet = true;
    }

    public void Balance()
    {
        transform.position = new Vector3 (-3.8F, 3.8F, -5);

        BalanceScript.enabled = true;
    }

    public void Car()
    {
        EventScript.LuzhaCarTrigger = true;
    }

    public void StartStopBalance()
    {
        BalanceScript.enabled = false;

        EventScript.LuzhaOff = true;

        EventScript.LuzhaButtons = false;
    }

    public void StopBalance()
    {
        EventScript.LuzhaEnd = true;
    }

    public void Continue()
    {
        EventScript.Continue();
    }

    public void ShowButtons()
    {
        EventScript.LuzhaButtons = true;
    }
}
