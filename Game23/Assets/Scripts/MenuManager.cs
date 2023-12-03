using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel("Level_1");
    }

    public void PlayOfficeGame()
    {
        Application.LoadLevel("Level_2");
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
