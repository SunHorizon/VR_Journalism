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
        Debug.Log("In GameManager->ChangeScene");
        Debug.Log(scene_);

        if (scene_ == "FrontDoor")
        {
            Debug.Log("FrontDoor");
            SceneManager.LoadScene(0);
        }
        if (scene_ == "Room1")
        {
            Debug.Log("Room1");
            SceneManager.LoadScene(1);
        }
        if (scene_ == "Room2")
        {
            Debug.Log("Room2");
            SceneManager.LoadScene(2);
        }
        if (scene_ == "WalkWay")
        {
            Debug.Log("WalkWay");
            SceneManager.LoadScene(3);
        }
        if (scene_ == "Room4")
        {
            Debug.Log("Room4");
            SceneManager.LoadScene(4);
        }
    }
}
