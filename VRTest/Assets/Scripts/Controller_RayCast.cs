using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using Valve.VR;

public class Controller_RayCast : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObj;       // The tracked object that is the controller
    public SteamVR_Action_Boolean grabPinch; //Grab Pinch is the trigger, select from inspecter
    public SteamVR_Input_Sources inputSource = SteamVR_Input_Sources.RightHand;//which controller

   
    
       
    //LayerMask mask;

    private LineRenderer line;

    void Start()
    {
        //mask = LayerMask.GetMask("Wall");
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, transform.position);//drawing the line renderer
        line.SetPosition(1, transform.TransformDirection(Vector3.forward) * 100);
        if (SteamVR_Actions._default.GrabPinch.GetStateDown(inputSource))
        {
            CheckForDoor();
        }
       
       
    }

    void CheckForDoor() { 

        RaycastHit hit;        
       
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.green);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 100))//layerMask for layer 8 for "Wall
        {
            if (hit.collider.name == "FootSteps1_1")
            {
                VideoPlayerClips video = new VideoPlayerClips();
                video.GetVideoIndex(1);

            }
            else {
                string objectName = hit.collider.name;
                Debug.Log(objectName);
                GameManager.ChangeScenes(objectName);
            }
                //Debug.Log("Raycast from controller is Hitting the door changing object");

                
            }
        }
        
}


