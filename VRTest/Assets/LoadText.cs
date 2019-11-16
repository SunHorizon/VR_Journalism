using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{

    private Text InfoText;
    [SerializeField] private string WriteInfo;
    [SerializeField] private float WriteTimer;
    public bool TextComlp;


    // Start is called before the first frame update
    void Start()
    {
        TextComlp = false;
    }

    public void startText()
    {
        StartCoroutine("TypeText");
    }

    public void StopText()
    {
        StopCoroutine("TypeText");
    }

    public void SetInfoText(Text InfoText_)
    {
        InfoText = InfoText_;
    }

    private IEnumerator TypeText()
    {
        InfoText.text = "";

        foreach (char letter in WriteInfo.ToCharArray())
        {
            InfoText.text += letter;
            yield return new WaitForSeconds(WriteTimer);
        }

        TextComlp = true;
    }
}
