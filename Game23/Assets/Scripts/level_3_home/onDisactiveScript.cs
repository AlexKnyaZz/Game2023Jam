/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDisactiveScript : MonoBehaviour
{

    public GameObject targetObject;

    private bool hasIncreasedCounter = false;

    void OnDisable()
    {
        // ���������, ���� �� ��� ���������� ��������
        if (!hasIncreasedCounter)
        {
            // ����������� ���������� �������
            GlobalCountsManagerScript.Instance.IncrementDeactivationCounter();

            // ��������, ��� ���������� �������� ��� ���������
            hasIncreasedCounter = true;
        }
    }

    //Debug.Log("Counter Increased. New Value: " + GlobalCountsManagerScript.Instance.GetDeactivationCounter());
    //// ����� ������ ���������� ����������, ����������� ������� ������������
    //GlobalCountsManagerScript.Instance.deactivationCounter += 1;
//}
}
*/