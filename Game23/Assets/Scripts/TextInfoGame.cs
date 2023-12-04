using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextInfoGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");

        }
    }
}
