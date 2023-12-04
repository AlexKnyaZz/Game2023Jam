using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicks : MonoBehaviour
{
    public AudioSource ClickSound;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ClickSound.Play();
        }
    }
}
