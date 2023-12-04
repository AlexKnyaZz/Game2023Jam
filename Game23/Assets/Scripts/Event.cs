using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    public GameObject BackGroundObject;

    //Character
    public CharacterMovement CharacterMovementScript;

    public Animator CharacterAnimator;

    public GameObject ParentObject;

    public AudioSource CharacterWalk;
    //Character

    //Luzha
    public GameObject LuzhaPerfab;

    public float LuzhaTriggerCord;

    public bool LuzhaTriggered;

    public bool LuzhaOff;

    public bool LuzhaEnd;

    public bool LuzhaCarTrigger;

    public GameObject LuzhaCar;

    public bool LuzhaButtons;

    public List<Image> LuzhaButtonsList = new List<Image>();

    public float LuzhaButtonsSpeed;

    public AudioSource LavaSound;
    //Luzha

    //Lava
    public Animator Luzha1Animator;
    public Animator Luzha2Animator;

    public Animator LavaAnimator;

    public Animator Canat1Animator;
    public Animator Canat2Animator;
    //Lava

    //Cat
    public GameObject Cat;

    public Animator CatAnimator;

    public float CatTriggerCord;

    public bool CatTriggered;

    public bool CatIsSitting;

    public bool CatVstaet;

    public bool CatEnd;

    public float PatTriggerCord;

    //Grass
    public Animator grass1Animator;

    public Animator grass2Animator;

    public Animator grass3Animator;
    //Grass

    /// 
    /// 
    /// 
    public float inOfficeCord;
    public float inOfficeCord1;
    /// 
    /// 
    /// 

    //Cat

    private void Start()
    {
        if (LuzhaTriggerCord != 0)
        {
            //GameObject Luzha = Instantiate(LuzhaPerfab, new Vector3(23, 23, -1), Quaternion.Euler(0, 0, 0), BackGroundObject.transform);
        }
    }

    private void Update()
    {
        //Luzha
        if (LuzhaTriggerCord != 0)
        {
            if (BackGroundObject.transform.position.x <= LuzhaTriggerCord && LuzhaTriggered == false)
            {
                Stop();

                CharacterWalk.enabled = true;

                CharacterAnimator.ResetTrigger("Idle");
                CharacterAnimator.ResetTrigger("Walk");
                CharacterAnimator.SetTrigger("Bordur");

                LuzhaTriggered = true;
            }
            if (LuzhaOff == true && LuzhaEnd == false)
            {
                CharacterAnimator.gameObject.transform.rotation = Quaternion.Lerp(CharacterAnimator.gameObject.transform.rotation, new Quaternion(0f, 0f, 0f, 1), 0.05F);

                ParentObject.transform.position = Vector3.Lerp(ParentObject.transform.position, new Vector3(0, 0, 0), 0.05F);
            }
            if (LuzhaCarTrigger == true)
            {
                LuzhaCar.SetActive(true);

                LuzhaCarTrigger = false;
            }
            if (LuzhaButtons == true)
            {
                for (int i = 0; i < LuzhaButtonsList.Count; i++)
                {
                    Color color = LuzhaButtonsList[i].color;

                    float number = color.a;

                    if (!(number > 1))
                    {
                        LuzhaButtonsList[i].color = new Color(color.r, color.g, color.b, color.a + LuzhaButtonsSpeed);
                    }
                }
            }
            else
            {
                for (int i = 0; i < LuzhaButtonsList.Count; i++)
                {
                    Color color = LuzhaButtonsList[i].color;

                    float number = color.a;

                    if (!(number < -0.01))
                    {
                        LuzhaButtonsList[i].color = new Color(color.r, color.g, color.b, color.a - LuzhaButtonsSpeed);
                    }
                }
            }
            if (BackGroundObject.transform.position.x <= inOfficeCord1)
            {
                GlobalCountsManagerScript.Instance.bedCount++;
                SceneManager.LoadScene("LevelOffice");
            }
        }
        //Luzha

        //Cat
        if (CatTriggerCord != 0)
        {
            if (BackGroundObject.transform.position.x <= CatTriggerCord && CatTriggered == false)
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

            if (BackGroundObject.transform.position.x <= inOfficeCord)
            {
                SceneManager.LoadScene("LevelOffice");
            }
        }
        //Cat
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
        CharacterWalk.enabled = false;
    }

    public void Continue()
    {
        CharacterMovementScript.enabled = true;
    }

    public void StartBalance()
    {
        Luzha1Animator.SetTrigger("Appear");
        Luzha2Animator.SetTrigger("Appear");

        LavaAnimator.SetTrigger("Appear");

        Canat1Animator.SetTrigger("Appear");
        Canat2Animator.SetTrigger("Appear");

        LavaSound.enabled = true;
    }

    public void StopBalance()
    {
        Luzha1Animator.SetTrigger("Disappear");
        Luzha2Animator.SetTrigger("Disappear");

        LavaAnimator.SetTrigger("Disappear");

        Canat1Animator.SetTrigger("Disappear");
        Canat2Animator.SetTrigger("Disappear");

        LavaSound.enabled = false;
    }

    public void StartGrass()
    {
        grass1Animator.SetTrigger("Appear");
        grass2Animator.SetTrigger("Appear");
        grass3Animator.SetTrigger("Appear");
    }

    public void StopGrass()
    {
        grass1Animator.SetTrigger("Disappear");
        grass2Animator.SetTrigger("Disappear");
        grass3Animator.SetTrigger("Disappear");
    }
}
