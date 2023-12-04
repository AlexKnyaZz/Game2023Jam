using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCountsManagerScript : MonoBehaviour
{
    // ����������� ������� ��� ����� ����
    public static GlobalCountsManagerScript Instance;

    // ������� ���������� �����������
    [SerializeField]
    public int guitarCount = 0;

    // ����� ��� ���������� �������� �����������
    public void IncrementGuitarCounter()
    {
        guitarCount++;
    }

    // ����� ��� ��������� ���������� �����������
    public int GetGuitarCounter()
    {
        return guitarCount;
    }

    [SerializeField]
    public int tvCount = 0;

    // ����� ��� ���������� �������� �����������
    public void IncrementTvCounter()
    {
        tvCount++;
    }

    // ����� ��� ��������� ���������� �����������
    public int GetTvCounter()
    {
        return tvCount;
    }


    [SerializeField]
    public int bedCount = 0;

    // ����� ��� ���������� �������� �����������
    public void IncrementBedCounter()
    {
        bedCount++;
    }

    // ����� ��� ��������� ���������� �����������
    public int GetBedCounter()
    {
        return bedCount;
    }



    [SerializeField]
    public int sound = 0;

    // ����� ��� ���������� �������� �����������
    public void IncrementSound()
    {
        sound++;
    }

    // ����� ��� ��������� ���������� �����������
    public int GetSound()
    {
        return sound;
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
