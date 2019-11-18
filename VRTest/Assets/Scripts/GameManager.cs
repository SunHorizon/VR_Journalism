using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public void ChangeScenes(string scene_)
    {        
        if (scene_ == "FrontDoor")
        {            
            SceneManager.LoadScene(0);
        }
        if (scene_ == "Room1")
        {           
            SceneManager.LoadScene(1);
        }
        if (scene_ == "Room1_1")
        {           
            SceneManager.LoadScene(2);
        }
        if (scene_ == "Room2")
        {           
            SceneManager.LoadScene(3);
        }
        if (scene_ == "Room2_2")
        {           
            SceneManager.LoadScene(4);
        }
        if (scene_ == "Room2_3")
        {           
            SceneManager.LoadScene(5);
        }
        if (scene_ == "WalkWay")
        {           
            SceneManager.LoadScene(6);
        }
        if (scene_ == "Room4")
        {           
            SceneManager.LoadScene(7);
        }
    }
}
