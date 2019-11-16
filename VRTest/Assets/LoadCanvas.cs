using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCanvas : MonoBehaviour
{
    public int LoadingTimer;

    // counter to check when to load in the UI
    public int loadCounter;

    // canvas group
    private CanvasGroup canvasGroup;

    // fade in and out bools
    private bool fadingIn;
    private bool fadingOut;

    // Timer of fade
    public float fadeTimeIn;
    public float fadeTimeOut;

    // Start is called before the first frame update
    void Start()
    {
        LoadingTimer = 0;
        canvasGroup = transform.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LoadTimer(int Timer_)
    {
        LoadingTimer += Timer_;
    }

    public void resetTimer(int Timer_)
    {
        LoadingTimer = Timer_;
    }

    public void StartLoading()
    {
        StartCoroutine("FadeIn");
    }

    public void StartFadeOut()
    {
        StartCoroutine("FadeOut");
    }

    private IEnumerator FadeOut()
    {
        if (!fadingOut)
        {
            fadingOut = true;
            fadingIn = false;

            // making sure to not fade in and out at the same time
            StopCoroutine("FadeIn");

            // Aptha value of inventory
            float startAlpha = canvasGroup.alpha;

            // the rate to fade out
            float rate = 1.0f / fadeTimeOut;

            // progress of the fade 
            float progress = 0.0f;

            // keep fading out till the inventory is not visible
            while (progress < 1.0)
            {
                // fading out the inventory
                canvasGroup.alpha = Mathf.Lerp(startAlpha, 0, progress);

                // increase the progress with the rate
                progress += rate * Time.deltaTime;

                yield return null;
            }
            // when done fading
            canvasGroup.alpha = 0;
            fadingOut = false;
        }
    }

    private IEnumerator FadeIn()
    {
        if (!fadingIn)
        {
            fadingOut = false;
            fadingIn = true;

            // making sure to not fade in and out at the same time
            StopCoroutine("FadeOut");

            // Aptha value of inventory
            float startAlpha = canvasGroup.alpha;

            // the rate to fade out
            float rate = 1.0f / fadeTimeIn;

            // progress of the fade 
            float progress = 0.0f;

            // keep fading in till the inventory is visible
            while (progress < 1.0)
            {
                // fading out the inventory
                canvasGroup.alpha = Mathf.Lerp(startAlpha, 1, progress);

                // increase the progress with the rate
                progress += rate * Time.deltaTime;

                yield return null;
            }

            // when done fading
            canvasGroup.alpha = 1;
            fadingIn = false;
        }
    }
}
