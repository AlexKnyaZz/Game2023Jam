using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Manage : MonoBehaviour
{
    // Объект, который деактивируется другими методами
    public GameObject targetObject;

    // Список объектов, которые нужно активировать при дне
    public GameObject[] dayObjects;

    // Список объектов, которые нужно активировать при ночи
    public GameObject[] nightObjects;

    void Start()
    {
        // Активируем объекты в зависимости от значения переменной IsDay
        ActivateObjects(GlobalCountsManagerScript.IsDay ? dayObjects : nightObjects);

        // Смена дня/ночи
        GlobalCountsManagerScript.IsDay = !GlobalCountsManagerScript.IsDay;

        // Увеличиваем счетчик после использования
        GlobalCountsManagerScript.IncrementCounter();

        

    }

    // Метод для активации или деактивации объектов
    private void ActivateObjects(GameObject[] objects)
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(true);
        }
    }
}
