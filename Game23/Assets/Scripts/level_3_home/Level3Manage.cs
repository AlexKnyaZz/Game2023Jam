using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Manage : MonoBehaviour
{
    // ������, ������� �������������� ������� ��������
    public GameObject targetObject;

    // ������ ��������, ������� ����� ������������ ��� ���
    public GameObject[] dayObjects;

    // ������ ��������, ������� ����� ������������ ��� ����
    public GameObject[] nightObjects;

    void Start()
    {
        // ���������� ������� � ����������� �� �������� ���������� IsDay
        ActivateObjects(GlobalCountsManagerScript.IsDay ? dayObjects : nightObjects);

        // ����� ���/����
        GlobalCountsManagerScript.IsDay = !GlobalCountsManagerScript.IsDay;

        // ����������� ������� ����� �������������
        GlobalCountsManagerScript.IncrementCounter();

        

    }

    // ����� ��� ��������� ��� ����������� ��������
    private void ActivateObjects(GameObject[] objects)
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(true);
        }
    }
}
