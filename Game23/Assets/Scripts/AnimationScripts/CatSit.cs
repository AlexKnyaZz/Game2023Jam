using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSit : MonoBehaviour
{
    public Event EventScript;

    public void Continue()
    {
        EventScript.Continue();
    }

    public void CatEnd()
    {
        EventScript.CatEnding();
    }

    public void CatNewStart()
    {
        EventScript.StartGrass();

        EventScript.AppearCatText2();
    }

    public void CatNewEnd()
    {
        EventScript.StopGrass();

        EventScript.AppearCatText3();
    }
}
