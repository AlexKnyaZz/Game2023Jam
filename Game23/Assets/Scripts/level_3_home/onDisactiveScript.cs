using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDisactiveScript : MonoBehaviour
{

    public GameObject targetObject;

    private bool hasIncreasedCounter = false;

    void OnDisable()
    {
        // Проверяем, было ли уже увеличение счетчика
        if (!hasIncreasedCounter)
        {
            // Увеличиваем глобальный счетчик
            GlobalCountsManagerScript.Instance.IncrementDeactivationCounter();

            // Помечаем, что увеличение счетчика уже выполнено
            hasIncreasedCounter = true;
        }
    }

    //Debug.Log("Counter Increased. New Value: " + GlobalCountsManagerScript.Instance.GetDeactivationCounter());
    //// Когда объект становится неактивным, увеличиваем счетчик исчезновений
    //GlobalCountsManagerScript.Instance.deactivationCounter += 1;
//}
}
