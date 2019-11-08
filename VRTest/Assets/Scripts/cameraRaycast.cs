using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class cameraRaycast : MonoBehaviour
{
    // ray cast hit 
    private RaycastHit hit;

    // loading slider
    public Slider loading;
    // canvas object
    public GameObject canvas;

    // counter to check when to load in the UI
    [SerializeField] private int loadCounter;

    // canvas group
    private CanvasGroup canvasGroup;

    // fade in and out bools
    private bool fadingIn;
    private bool fadingOut;

    // Timer of fade
    public float fadeTimeIn;
    public float fadeTimeOut;

    private int loadTimer;

    [SerializeField] private Text InfoText;
    [SerializeField] private string WriteInfo;
    [SerializeField] private float WriteTimer;
    private bool TextComlp;

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = canvas.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;

        loading.maxValue = loadCounter;
        loadTimer = 0;
        TextComlp = false;
    }

    // Update is called once per frame
    void Update()
    {
        // load the UI in word space
        LoadingUI();

        if (loadTimer == loadCounter)
        {

            StartCoroutine("FadeIn");
            if (!TextComlp)
            {
                StartCoroutine("TypeText");
            }
           
        }
    }

    void LoadingUI()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 30, Color.red);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 20) && hit.transform.gameObject.tag == "Wall")
        {
            loading.value++;
            loadTimer++;
        }
        else
        {
            loading.value = 0;
            loadTimer = 0;
           
            StartCoroutine("FadeOut"); // start the coroutine to close inventory 
            if (!TextComlp)
            {
                StopCoroutine("TypeText");
            }         
        }
    }

    private IEnumerator TypeText()
    {
        InfoText.text = "";
       
        foreach (char letter in WriteInfo.ToCharArray())
        {
            InfoText.text += letter;
            Debug.Log(letter);
            yield return new WaitForSeconds(WriteTimer);
        }

        TextComlp = true;
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
