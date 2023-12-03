using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCountsManagerScript : MonoBehaviour
{
    // Нерушимость объекта при смене сцен
    public static GlobalCountsManagerScript Instance;

    // Счетчик количества деактиваций
    [SerializeField]
    public int deactivationCounter = 0;

    // Метод для увеличения счетчика деактиваций
    public void IncrementDeactivationCounter()
    {
        deactivationCounter++;
    }

    // Метод для получения количества деактиваций
    public int GetDeactivationCounter()
    {
        return deactivationCounter;
    }

    // Всё, что касается дня
    // Статическая переменная, представляющая день или ночь
    private static bool isDay = true;

    // Свойство для доступа к переменной
    public static bool IsDay
    {
        get { return isDay; }
        set { isDay = value; }
    }

    // Статическая переменная-счетчик для того, чтобы проверить день или нет
    private static int counter = 0;

    // Метод для увеличения счетчика
    public static void IncrementCounter()
    {
        counter++;
    }

    // Метод для получения текущего значения счетчика
    public static int GetCounter()
    {
        return counter;
    }
    // Всё, что касается дня

    // Нерушимость объекта при смене сцен
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Нерушимость объекта при смене сцен
}
