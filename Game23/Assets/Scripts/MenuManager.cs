using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel("Epilog");
    }

    public void PlayOfficeGame()
    {
        Application.LoadLevel("InfoGame");
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
