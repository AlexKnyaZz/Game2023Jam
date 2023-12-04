using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel("LevelHome");
    }

    public void PlayOfficeGame()
    {
        Application.LoadLevel("LevelOffice");
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
