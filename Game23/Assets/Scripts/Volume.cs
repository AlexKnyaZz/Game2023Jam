using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
    public List<AudioSource> AudioSourceList = new List<AudioSource>();

    public float VolumeNumber;

    public GlobalCountsManagerScript GlobalCountsManagerScriptScript;

    public bool IsMenu;

    private void Start()
    {
        if (GlobalCountsManagerScriptScript == null)
        {
            GlobalCountsManagerScriptScript = Object.FindObjectOfType<GlobalCountsManagerScript>();
        }

        VolumeNumber = (float)GlobalCountsManagerScriptScript.sound / 100;

        for (int i = 0; i < AudioSourceList.Count; i++)
        {
            AudioSourceList[i].volume = VolumeNumber;
        }
    }

    private void Update()
    {
        if (IsMenu == true)
        {
            VolumeNumber = (float)GlobalCountsManagerScriptScript.sound / 100;

            for (int i = 0; i < AudioSourceList.Count; i++)
            {
                AudioSourceList[i].volume = VolumeNumber;
            }
        }
    }
}
