using System.Collections;
using TMPro; // Или использовать UnityEngine.UI, если используете Text вместо TextMeshPro
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextEpilog : MonoBehaviour
{
    public TextMeshProUGUI textMeshProComponent; // Используйте Text, если не используете TextMeshPro
    public TextMeshProUGUI textMeshProComponent1;
    public TextMeshProUGUI textMeshProComponent2;
    public TextMeshProUGUI textMeshProComponent3;
    public string fullText = "Прошло три долгих года с того момента, как я окончил университет, защитив диплом на отлично. К своему удивлению, я довольно быстро нашел работу, наивно полагая, что нашел работу мечты.";
    public string fullText1 = "Первое время, полный энтузиазма, я работал не покладая сил. Однако с течением времени запал угас, а моя «идеальная» работа стала только угнетать.";
    public string fullText2 = "Работа, о которой я так мечтал, оказалась монотонной и утомительной, а неудержимая текучка кадров привела к бесконечным переработкам и отсутствию выходных. Постепенно, из-за неизменной повседневности и однообразия, цвета этого мира потускнели для меня. Каждый день стал сливаться в серую обыденность, а я утратил какие-либо краски в этой серой реальности.";
    public string fullText3 = "Возможно, есть шанс изменить эту монотонность и найти новые оттенки в своей жизни?";
    public float delayBetweenCharacters = 0.1f;

    private void Start()
    {
        StartCoroutine(PrintText());
    }

    IEnumerator PrintText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            string currentText = fullText.Substring(0, i);
            // Присваиваем текущий текст компоненту TextMeshPro
            textMeshProComponent.text = currentText;
            // Или использовать textComponent.text, если используете Text вместо TextMeshPro

            yield return new WaitForSeconds(delayBetweenCharacters);
        }
        textMeshProComponent1.gameObject.SetActive(true);

        for (int i = 0; i <= fullText1.Length; i++)
        {
            string currentText = fullText1.Substring(0, i);
            // Присваиваем текущий текст компоненту TextMeshPro
            textMeshProComponent1.text = currentText;
            // Или использовать textComponent.text, если используете Text вместо TextMeshPro

            yield return new WaitForSeconds(delayBetweenCharacters);
        }
        textMeshProComponent2.gameObject.SetActive(true);
        for (int i = 0; i <= fullText2.Length; i++)
        {
            string currentText = fullText2.Substring(0, i);
            // Присваиваем текущий текст компоненту TextMeshPro
            textMeshProComponent2.text = currentText;
            // Или использовать textComponent.text, если используете Text вместо TextMeshPro

            yield return new WaitForSeconds(delayBetweenCharacters);
        }
        textMeshProComponent3.gameObject.SetActive(true);
        for (int i = 0; i <= fullText3.Length; i++)
        {
            string currentText = fullText3.Substring(0, i);
            // Присваиваем текущий текст компоненту TextMeshPro
            textMeshProComponent3.text = currentText;
            // Или использовать textComponent.text, если используете Text вместо TextMeshPro

            yield return new WaitForSeconds(delayBetweenCharacters);
        }

    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("LevelHome");

        }
    }

}


