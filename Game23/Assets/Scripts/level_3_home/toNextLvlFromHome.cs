using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toNextLvlFromHome : MonoBehaviour
{


    public void OnMouseDown()
    {
        StartCoroutine(waitingTimeBeforeLoadNextLvl());
    }

    private IEnumerator waitingTimeBeforeLoadNextLvl()
    {
        if (gameObject.CompareTag("door")) {
            yield return new WaitForSeconds(4f);
            SceneManager.LoadScene("Level_1");
        }
        if (gameObject.CompareTag("bed"))
        {
            yield return new WaitForSeconds(4f);
            SceneManager.LoadScene("Level_2");
        }
    }
}
