using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCountsManagerScript : MonoBehaviour
{
    // ����������� ������� ��� ����� ����
    public static GlobalCountsManagerScript Instance;

    // ������� ���������� �����������
    [SerializeField]
    public int deactivationCounter = 0;

    // ����� ��� ���������� �������� �����������
    public void IncrementDeactivationCounter()
    {
        deactivationCounter++;
    }

    // ����� ��� ��������� ���������� �����������
    public int GetDeactivationCounter()
    {
        return deactivationCounter;
    }

    // ��, ��� �������� ���
    // ����������� ����������, �������������� ���� ��� ����
    private static bool isDay = true;

    // �������� ��� ������� � ����������
    public static bool IsDay
    {
        get { return isDay; }
        set { isDay = value; }
    }

    // ����������� ����������-������� ��� ����, ����� ��������� ���� ��� ���
    private static int counter = 0;

    // ����� ��� ���������� ��������
    public static void IncrementCounter()
    {
        counter++;
    }

    // ����� ��� ��������� �������� �������� ��������
    public static int GetCounter()
    {
        return counter;
    }
    // ��, ��� �������� ���

    // ����������� ������� ��� ����� ����
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
    // ����������� ������� ��� ����� ����
}
