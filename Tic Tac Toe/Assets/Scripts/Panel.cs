using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField]
    private float fadeTime;
    [SerializeField]
    private CanvasGroup canvasGroup;
    [SerializeField]
    private GameObject _panelObject;
    public void OpenPanel()
    {
        StartCoroutine(FadeInCanvas());
    }
    private IEnumerator FadeInCanvas()
    {
        _panelObject.SetActive(true);
        float curentAlpha = canvasGroup.alpha;
        float time = 0;
        while (time < fadeTime)
        {
            time += Time.deltaTime;
            float alpha = time / fadeTime;
            canvasGroup.alpha = Mathf.Lerp(curentAlpha, 1, alpha);
            yield return new WaitForEndOfFrame();
        }
    }
}
