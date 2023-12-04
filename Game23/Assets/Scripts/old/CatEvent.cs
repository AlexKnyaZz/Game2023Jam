using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatEvent : MonoBehaviour
{
    public GameObject BackGroundObject;

    //Character
    public CharacterMovement CharacterMovementScript;

    public Animator CharacterAnimator;
    //Character

    //Cat
    public GameObject Cat;

    public Animator CatAnimator;

    public float TriggerCord;

    public bool CatTriggered;

    public bool CatIsSitting;

    public bool CatVstaet;

    public bool CatEnd;

    public float PatTriggerCord;
    /// 
    /// 
    /// 
    public float inOfficeCord;
    /// 
    /// 
    /// 

    //Cat

    private void Update()
    {
        //Cat
        if (BackGroundObject.transform.position.x <= TriggerCord && CatTriggered == false)
        {
            Cat.SetActive(true);

            Stop();

            CatAnimator.SetTrigger("Walk");

            CatTriggered = true;

            CatIsSitting = true;
        }

        if (BackGroundObject.transform.position.x <= PatTriggerCord && CatIsSitting == true)
        {
            Stop();

            CatIsSitting = false;

            CharacterAnimator.SetTrigger("Nakl");
        }

        if (CatVstaet == true)
        {
            CatAnimator.SetTrigger("Vstaet");

            CharacterAnimator.SetTrigger("Vstaet");
        }
        //Cat

        //Cat

        if (BackGroundObject.transform.position.x <= inOfficeCord)
        {
            SceneManager.LoadScene("LevelOffice");
        }
    }

    //Cat
    public void CatEnding()
    {
        Cat.SetActive(false);

        Continue();
    }
    //Cat

    public void Stop()
    {
        CharacterMovementScript.enabled = false;
        CharacterAnimator.SetTrigger("Idle");
        CharacterAnimator.ResetTrigger("Walk");
    }

    public void Continue()
    {
        CharacterMovementScript.enabled = true;
    }


    

}
