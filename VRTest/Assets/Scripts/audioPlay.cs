using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{
    public AudioSource voiceover;
    // Start is called before the first frame update
    void Start()
    {
        voiceover.Play();
    }

    // Update is called once per frame
    void Update()
    {        
        
        if (voiceover.isPlaying)
        {
            Debug.Log("aaaaaaaaaaaaaahhhhhhhhhhh");
        }
    }
}
