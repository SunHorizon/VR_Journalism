using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerClips : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    //public List<VideoClip> videos = new List<VideoClip>();
    public VideoClip[] videos;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.playOnAwake = true;
        videoPlayer.clip = videos[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetVideoIndex(int index_)
    {
        Debug.Log(index_);
        videoPlayer.clip = videos[index_];//getting null ptr      
        videoPlayer.Play();
        //move camera to shift doors, and stuff
    }
}
