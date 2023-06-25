using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Image loadbar;
    
    public void LoadScene(int index)
    {
        //Включаете UI
        StartCoroutine(AsyncLoad(index));
    }


    /// <summary>
    /// Ассихронная загрузка
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    private IEnumerator AsyncLoad(int index)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(index);
        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            text.text = Mathf.Round(progress*100) + "%";
            loadbar.fillAmount = progress;
            print(Mathf.Round(progress*100) + "%");
            yield return null;
        }
    }
}
