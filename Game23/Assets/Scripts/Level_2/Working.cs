using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Working : MonoBehaviour
{
    private float timer = 0f;
    private int ButtonClick = 0;
    private int FinalLetter = 0;
    private bool WakeUp = false;

    public GameObject Of1; 
    public GameObject Of2; 
    public GameObject Of3; 
    public GameObject Of3_1; 
    public GameObject Of3_2; 
    public GameObject dark1; 
    public GameObject dark2; 
    public GameObject dark3; 
    public GameObject textObj; 
    public GameObject textEnter; 

    private float timerStart = 0f;
    private bool timerStartedFirst = false;


    private bool timerStarted = true;
    
   
    // Update is called once per frame


    void Update()
    {
        
        if (!timerStartedFirst)
        {
            timer += Time.deltaTime;

            if (timer >= 1.5f)
            {   
                Of1.SetActive(false);
                Of3.SetActive(false);
                Of3_1.SetActive(false);
                Of3_2.SetActive(false);
                Of2.SetActive(true);
            }

            if (timer >= 2.5f)
            {   
                dark1.SetActive(true);
            }


            if (timer >= 5f)
            {   
                dark1.SetActive(false);
                dark2.SetActive(true);
            }

            if (timer >= 6f)
            {   
                Of2.SetActive(false);
                if (FinalLetter == 0)
                {
                    Of3.SetActive(true);
                }
                else if (FinalLetter == 1)
                {
                    Of3_1.SetActive(true);
                }
                else if (FinalLetter == 2)
                {
                    Of3_2.SetActive(true);
                }
                timer = 0f;
                textObj.SetActive(true);
                WakeUp = false;
                timerStartedFirst = true; 
                timerStarted = false; 
            }
        }

        if (FinalLetter < 3)
        {
            if (timerStartedFirst && !timerStarted)
            {
                timer += Time.deltaTime;


                if (Input.GetKeyDown(KeyCode.E) && !WakeUp)
                {
                    ButtonClick++;
                }


                if (timer >= 5f)
                {
                
                
                    if (ButtonClick < 20 && dark2.activeSelf == true)
                    {
                        dark2.SetActive(false);
                        dark3.SetActive(true);
                        textObj.SetActive(true);
                        timer = 0f;
                        ButtonClick = 0;
                    }
                    else if (ButtonClick < 20 && dark1.activeSelf == true)
                    {
                        dark1.SetActive(false);
                        dark2.SetActive(true);
                        textObj.SetActive(true);
                        timer = 0f;
                        ButtonClick = 0;
                    }
                    else if (ButtonClick >= 20 && dark2.activeSelf == true)
                    {
                        dark2.SetActive(false);
                        dark1.SetActive(true);
                        textObj.SetActive(false);
                        timer = 0f;
                        ButtonClick = 0;
                    }
                    else if (ButtonClick >= 20 && dark3.activeSelf == true)
                    {
                        dark3.SetActive(false);
                        dark2.SetActive(true);
                        textObj.SetActive(false);
                        timer = 0f;
                        ButtonClick = 0;
                    }
                    else if (ButtonClick >= 20 && dark1.activeSelf == true)
                    {
                        dark1.SetActive(false);
                        textObj.SetActive(false);
                        timer = 0f;
                        WakeUp = true;
                        ButtonClick = 0;
                    }
                    else if (ButtonClick < 20 && WakeUp)
                    {
                        dark1.SetActive(true);
                        textObj.SetActive(false);
                        textEnter.SetActive(false);
                        timer = 0f;
                        ButtonClick = 0;
                        WakeUp = false;
                    }

                
                
                }
            
                if (WakeUp)
                {

                    textEnter.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
                    {
                        textEnter.SetActive(false);
                        FinalLetter++;
                        timerStartedFirst = false; 
                        timerStarted = true; 

                    }
                }
            } 
        }
        else
        {
           Debug.Log("Уровень кончился"); 
        }
    }  

}
