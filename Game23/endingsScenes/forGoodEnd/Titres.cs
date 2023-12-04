using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Titres : MonoBehaviour
{
    public TextMeshProUGUI uiText;

    private void OnEnable()
    {
        if (uiText == null)
        {
            uiText = GetComponent<TextMeshProUGUI>();
        }

        if (uiText != null)
        {
            StartCoroutine(FadeSequence());
        }
        else
        {
            Debug.LogError("TextMeshProUGUI component is missing!");
        }
    }

    private IEnumerator FadeSequence()
    {
        // ����� ������������� ����������� ������������
        SetTextAlpha(0.9f);
        yield return new WaitForSeconds(3f);

        // ������ ����� ���������� ����������
        SetTextAlpha(0.5f);
        yield return new WaitForSeconds(0.2f);

        // ������ ����� ����� ����������
        SetTextAlpha(0.3f);
        yield return new WaitForSeconds(0.2f);

        // ������ ����� ��������� ����������
        SetTextAlpha(0f);
        yield return new WaitForSeconds(0.2f);

        gameObject.SetActive(false); // ������������ ������
    }

    private void SetTextAlpha(float alpha)
    {
        if (uiText != null)
        {
            Color currentColor = uiText.color;
            uiText.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
        }
    }
}
