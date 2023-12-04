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
    public float delayMessage = 48f; // ����� �������� ��� ������ ��������� � �������

    private bool object1Activated = false;
    private bool object2Activated = false;

    void Start()
    {
        // ��������� ��������, ����� ������������ object1 ����� ��������� �����
        StartCoroutine(ActivateObject1AfterDelay());

        // �������� ����� ��� ������ ��������� ����� ��������� �����
        Invoke("PrintMessageToConsole", delayMessage);
    }

    IEnumerator ActivateObject1AfterDelay()
    {
        yield return new WaitForSeconds(delayObject1);

        // ���������� object1
        object1.SetActive(true);
        object1Activated = true;

        // ��������� �������� ��� ��������� object2 ����� ��������� �����, ������ ���� object1 �������
        if (object1Activated)
        {
            StartCoroutine(ActivateObject2AfterDelay());
        }
    }

    IEnumerator ActivateObject2AfterDelay()
    {
        yield return new WaitForSeconds(delayObject2);

        // ���������� object2
        object2.SetActive(true);
        object2Activated = true;

        // ��������� �������� ��� ��������� object3 ����� ��������� �����, ������ ���� object2 �������
        if (object2Activated)
        {
            StartCoroutine(ActivateObject3AfterDelay());
        }
    }

    IEnumerator ActivateObject3AfterDelay()
    {
        yield return new WaitForSeconds(delayObject3);

        // ���������� object3
        object3.SetActive(true);
    }

    // ����� ��� ������ ��������� � �������
    void PrintMessageToConsole()
    {
        Debug.Log("������ 48 ������ � ������� ������� �����!");
        SceneManager.LoadScene("Menu");
    }
}
