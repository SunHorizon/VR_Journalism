using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class cameraRaycast : MonoBehaviour
{
    // ray cast hit 
    private RaycastHit hit;


    private LoadText textLoader;
    private LoadCanvas CanvasLoader;

    private Text InfoText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // load the UI in word space
        LoadingUI();

        if (CanvasLoader.LoadingTimer == CanvasLoader.loadCounter)
        {
            CanvasLoader.StartLoading();

            if (!textLoader.TextComlp)
            {
                textLoader.startText();
            }
        }
    }

    void LoadingUI()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 30, Color.red);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 20) && hit.transform.gameObject.tag == "Wall")
        {
        
           InfoText = hit.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<Text>();
           textLoader = hit.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<LoadText>();
           textLoader.SetInfoText(InfoText);

           CanvasLoader = hit.transform.GetChild(0).GetComponent<LoadCanvas>();
           CanvasLoader.LoadTimer(1);
        }
        else
        {
            CanvasLoader.resetTimer(0);

            CanvasLoader.StartFadeOut(); // start the coroutine to close inventory 
            if (!textLoader.TextComlp)
            {
                textLoader.StopText();
            }         
        }
    }

}
