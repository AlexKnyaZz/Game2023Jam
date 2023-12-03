using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject backgroundObject; // Присвойте сюда объект с компонентом Renderer (например, SpriteRenderer)



 
    public float transitionSpeed = 1f; // Скорость изменения цвета
    public float awakeningThreshold = 14f; // Количество нажатий для окончательного пробуждения
    private float awakeningProgress = 0f;

    public Color startColor = Color.white;
    public Color endColor = Color.black;
    public float sleepDuration = 2f; // Время засыпания в секундах
    public Color startColorAwake = Color.black;
    public Color endColorAwake = Color.white;
    private bool Night = true;

    private float sleepTimer = 0f;



    
    void Start()
    {
        // Устанавливаем начальный цвет фона в черный
        backgroundObject.GetComponent<Renderer>().material.color = startColorAwake;
    }


    void Update()
    {

        if (Night)
        {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Увеличиваем прогресс пробуждения
            awakeningProgress += 1f;

            //Обновляем цвет фона в соответствии с прогрессом
            float t = awakeningProgress / awakeningThreshold;
            backgroundObject.GetComponent<Renderer>().material.color = Color.Lerp(startColorAwake, endColorAwake, t);

            //Проверяем, достигнут ли порог пробуждения
            if (awakeningProgress >= awakeningThreshold)
            {
                //Действия после окончательного пробуждения
                Debug.Log("Герой проснулся!");
                //enabled = false; // Отключаем скрипт, чтобы прекратить обновление цвета
                Night = false;
                awakeningProgress = 0f;
            }
        }
        }
        else
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
            Night = true;
            sleepTimer = 0f;
        }
        }

    }
}




