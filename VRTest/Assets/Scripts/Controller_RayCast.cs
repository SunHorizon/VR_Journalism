﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_RayCast : MonoBehaviour
{
    //private SteamVR_TrackedController controller;
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
        CheckForDoor();
    }

    void CheckForDoor() {

        line.SetPosition(0, transform.position);//drawing the line renderer
        line.SetPosition(1, transform.TransformDirection(Vector3.forward) * 30);

        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 30, Color.green);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 20, 8))//layerMask for layer 8
        {
            //if(controller.Trigger){}
            Debug.Log("Raycast from controller is Hitting the door changing object");
            string objectName = hit.collider.tag;
            GameManager.ChangeScenes(objectName);
        }
        
    }
}