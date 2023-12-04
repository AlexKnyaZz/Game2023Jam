using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    public AudioSource Clock;
    public bool ClockTriggered;

    public GameObject Replica;



    // ������, ������� �������������� ������� ��������
    public GameObject targetObject;

    // ������ ��������, ������� ����� ������������ ��� ���
    public GameObject[] dayObjects;

    // ������ ��������, ������� ����� ������������ ��� ����
    public GameObject[] nightObjects;

    public GameObject[] goodObjects;

    public GameObject[] neutralObjects;

    public TextMeshProUGUI HomeText1;

    void Start()
    {
        if (GlobalCountsManagerScript.Instance.bedCount != 2)
        {
            // ���������� ������� � ����������� �� �������� ���������� IsDay
            ActivateObjects(GlobalCountsManagerScript.IsDay ? dayObjects : nightObjects);
        }
        if (GlobalCountsManagerScript.IsDay)
        {
            backgroundObject.GetComponent<Renderer>().material.color = startColorAwake;
            textMorningSpam.SetActive(true);
            Replica.SetActive(true);
            Morning = true;
        }


        // ����� ���/����
        GlobalCountsManagerScript.IsDay = !GlobalCountsManagerScript.IsDay;

        // ����������� ������� ����� �������������
        GlobalCountsManagerScript.IncrementCounter();


        if (GlobalCountsManagerScript.Instance.bedCount == 2)
        {
            if ((GlobalCountsManagerScript.Instance.guitarCount - GlobalCountsManagerScript.Instance.tvCount != 1) || (GlobalCountsManagerScript.Instance.tvCount - GlobalCountsManagerScript.Instance.guitarCount == 1))
            {
                ActivateObjects(neutralObjects);
            }
            if (GlobalCountsManagerScript.Instance.guitarCount - GlobalCountsManagerScript.Instance.tvCount == 1)
            {
                ActivateObjects(goodObjects);
            }
        }

        if (Morning)
        {
            Clock.Play();
        }
        else
        {
            HomeText1.text = "Надеюсь сегодня удастся лечь пораньше...";
            HomeText1.gameObject.SetActive(true);
        }
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
                Replica.SetActive(false);
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
