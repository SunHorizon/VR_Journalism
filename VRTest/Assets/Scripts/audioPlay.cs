using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{
    public AudioSource voiceover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
            voiceover.Play();
        if (voiceover.isPlaying)
        {
            Debug.Log("aaaaaaaaaaaaaahhhhhhhhhhh");
        }
    }
}
