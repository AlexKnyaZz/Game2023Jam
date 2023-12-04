using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Manage : MonoBehaviour
{
    public GameObject backgroundObject; // Присвойте сюда объект с компонентом Renderer (например, SpriteRenderer)
    public float transitionSpeed = 1f; // Скорость изменения цвета
    public float awakeningThreshold = 14f; // Количество нажатий для окончательного пробуждения
    private float awakeningProgress = 0f;
    public Color startColorAwake = Color.black;
    public Color endColorAwake = Color.white;
    private bool Morning = false;
    public GameObject textMorningSpam;



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

        if (GlobalCountsManagerScript.IsDay)
        {
            backgroundObject.GetComponent<Renderer>().material.color = startColorAwake;
            textMorningSpam.SetActive(true);
            Morning=true;
        }


        // ����� ���/����
        GlobalCountsManagerScript.IsDay = !GlobalCountsManagerScript.IsDay;

        // ����������� ������� ����� �������������
        GlobalCountsManagerScript.IncrementCounter();
    }

    void Update()
    {

        if (Morning)
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
                textMorningSpam.SetActive(false);
                //enabled = false; // Отключаем скрипт, чтобы прекратить обновление цвета
                Morning = false;
                awakeningProgress = 0f;
            }
        }
        }
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
