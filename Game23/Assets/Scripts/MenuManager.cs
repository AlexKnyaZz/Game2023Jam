using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour

    
{
    public GameObject SettingsPanel;
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

    public void ExitSettings()
    {
        SettingsPanel.SetActive(false);
    }

    public void Settings()
    {
        SettingsPanel.SetActive(true);
    }


}
