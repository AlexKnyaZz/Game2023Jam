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
        // Сразу устанавливаем минимальную прозрачность
        SetTextAlpha(0.9f);
        yield return new WaitForSeconds(3f);

        // делаем текст наполовину прозрачным
        SetTextAlpha(0.5f);
        yield return new WaitForSeconds(0.2f);

        // делаем текст более прозрачным
        SetTextAlpha(0.3f);
        yield return new WaitForSeconds(0.2f);

        // делаем текст полностью прозрачным
        SetTextAlpha(0f);
        yield return new WaitForSeconds(0.2f);

        gameObject.SetActive(false); // Деактивируем объект
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
