using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goodEndManage : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public float delayObject1 = 30f;
    public float delayObject2 = 3f;
    public float delayObject3 = 5f;
    public float delayMessage = 48f; // Время задержки для вывода сообщения в консоль

    private bool object1Activated = false;
    private bool object2Activated = false;

    void Start()
    {
        // Запускаем корутину, чтобы активировать object1 через указанное время
        StartCoroutine(ActivateObject1AfterDelay());

        // Вызываем метод для вывода сообщения через указанное время
        Invoke("PrintMessageToConsole", delayMessage);
    }

    IEnumerator ActivateObject1AfterDelay()
    {
        yield return new WaitForSeconds(delayObject1);

        // Активируем object1
        object1.SetActive(true);
        object1Activated = true;

        // Запускаем корутину для активации object2 через указанное время, только если object1 активен
        if (object1Activated)
        {
            StartCoroutine(ActivateObject2AfterDelay());
        }
    }

    IEnumerator ActivateObject2AfterDelay()
    {
        yield return new WaitForSeconds(delayObject2);

        // Активируем object2
        object2.SetActive(true);
        object2Activated = true;

        // Запускаем корутину для активации object3 через указанное время, только если object2 активен
        if (object2Activated)
        {
            StartCoroutine(ActivateObject3AfterDelay());
        }
    }

    IEnumerator ActivateObject3AfterDelay()
    {
        yield return new WaitForSeconds(delayObject3);

        // Активируем object3
        object3.SetActive(true);
    }

    // Метод для вывода сообщения в консоль
    void PrintMessageToConsole()
    {
        Debug.Log("Прошло 48 секунд с момента запуска сцены!");
        SceneManager.LoadScene("Menu");
    }
}
