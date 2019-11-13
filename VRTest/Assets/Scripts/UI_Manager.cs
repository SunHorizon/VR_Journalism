using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Valve.VR;

public class UI_Manager : MonoBehaviour
{
    //private Ray ray;
    //private RaycastHit hit;
    [SerializeField] private Camera camera;

    //[SerializeField]private Camera camera;


    // Start is called before the first frame update
    void Start()
    {
        //SteamVR_Controller.
    }

    // Update is called once per frame
    void Update()
    {
        //ray = camera.ViewportPointToRay(new Vector2(Screen.height / 2, Screen.width / 2));
        // // camera.transform.position
        //if (Physics.Raycast(ray, out hit))
        //{
        //    Debug.Log("testing");
        //    Debug.Log(hit.collider.name);
        //}

        //Debug.DrawRay(ray.origin, ray.direction, Color.red);
        Graze();
    }

    void Graze()
    {
        Debug.DrawRay(camera.transform.position, camera.transform.up * 5, Color.blue);
        RaycastHit2D hit = Physics2D.Raycast(camera.transform.position, camera.transform.up, 5);
        //Debug.Log(hit.collider.name);
        if (hit.collider)
        {
            Debug.Log(hit.collider.name);
        }
    }

}
