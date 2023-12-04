using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toNextLvlFromHome : MonoBehaviour
{

    public GameObject backgroundObject; // Присвойте сюда объект с компонентом Renderer (например, SpriteRenderer)
    public Color startColor = Color.white;
    public Color endColor = Color.black;
    public float sleepDuration = 2f; // Время засыпания в секундах
    private bool BedClick = false;

    private float sleepTimer = 0f;


    public void OnMouseDown()
    {
        StartCoroutine(waitingTimeBeforeLoadNextLvl());
    }

    private IEnumerator waitingTimeBeforeLoadNextLvl()
    {
        if (gameObject.CompareTag("door")) 
        {
            yield return new WaitForSeconds(4f);

            if(GlobalCountsManagerScript.Instance.bedCount == 0)
            {
                SceneManager.LoadScene("LevelCat");
            }
            else  if (GlobalCountsManagerScript.Instance.bedCount == 1)
            {
                SceneManager.LoadScene("LevelCar");
            }
            else if (GlobalCountsManagerScript.Instance.bedCount == 2)
            {
              if ((GlobalCountsManagerScript.Instance.guitarCount - GlobalCountsManagerScript.Instance.tvCount != 1) && (GlobalCountsManagerScript.Instance.tvCount - GlobalCountsManagerScript.Instance.guitarCount != 1)) 
              {
                SceneManager.LoadScene("neutralEnd");
              }  
            }
            
        }
        if (gameObject.CompareTag("bed"))
        {
            yield return new WaitForSeconds(4f);
            BedClick = true;
        }
        if (gameObject.CompareTag("guitar"))
        {
            if (GlobalCountsManagerScript.Instance.bedCount == 2)
            {
                if (GlobalCountsManagerScript.Instance.guitarCount - GlobalCountsManagerScript.Instance.tvCount == 1)
                {
                        SceneManager.LoadScene("goodEnd");
                }
            } 
        }
    }


     void Update()
    {
        if (BedClick)
        {
                        // Увеличиваем таймер засыпания
        sleepTimer += Time.deltaTime;

        // Интерполируем цвет от startColor к endColor в течение указанного времени
        float t = Mathf.Clamp01(sleepTimer / sleepDuration);
        backgroundObject.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);

        // Проверяем, завершено ли засыпание
        if (sleepTimer >= sleepDuration)
        {
            // Действия после засыпания
            Debug.Log("Герой заснул!");
            //enabled = false; // Отключаем скрипт, чтобы прекратить обновление цвета
            sleepTimer = 0f;
            BedClick = false;
            GlobalCountsManagerScript.Instance.bedCount += 1;  
            SceneManager.LoadScene("LevelHome");
        }
        }
    }



}
